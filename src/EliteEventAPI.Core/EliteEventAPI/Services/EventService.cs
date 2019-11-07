using EliteEventAPI.Configuration;
using EliteEventAPI.Services.Events;
using EliteEventAPI.Services.JournalParser;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace EliteEventAPI.Services
{
    public delegate void EventServiceEventDelegate(string eventname, EventModelBase model);
    public delegate void EventServiceJsonDelegate(string eventname, string json);

    public sealed class EventService : ServiceBase
    {
        private readonly Queue<string> _queue = new Queue<string>();
        private readonly EventServiceConfiguration _configuration;

        private readonly Dictionary<string, Type> _events = new Dictionary<string, Type>();
        private readonly Dictionary<Type, HashSet<Delegate>> _targets = new Dictionary<Type, HashSet<Delegate>>();
        private readonly JsonSerializerSettings _jsonsettings;

        public event EventServiceJsonDelegate PreEventCall;
        public event EventServiceEventDelegate EventCall;
        public event EventServiceJsonDelegate UnkownEventCall;

        public EventService()
        {
            ScanEvents();

            _jsonsettings = new JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Error,
                Error = new EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs>(JsonErrorEventHandler)
            };

            _configuration = ConfigurationManager.LoadConfiguration<EventServiceConfiguration>();

            JournalDirectory = new DirectoryInfo(Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "saved games", "Frontier Developments", "Elite Dangerous"));

            Reader = new JournalReader(this);

            StatusParser = new StatusParser(this);
            CargoParser = new CargoParser(this);
        }

        private void JsonErrorEventHandler(object sender, Newtonsoft.Json.Serialization.ErrorEventArgs e)
        {
            _ = e.ErrorContext.Error.Message;
        }

        private void ScanEvents()
        {
            var types = from asm in AppDomain.CurrentDomain.GetAssemblies()
                        from t in asm.GetTypes()
                        where t.IsSubclassOf(typeof(EventModelBase))
                        let instance = (EventModelBase)Activator.CreateInstance(t)
                        select new { instance.Eventname, Type = t };

            foreach (var item in types)
            {
                _events.Add(item.Eventname, item.Type);
                _targets.Add(item.Type, new HashSet<Delegate>());
            }
        }

        private void ShutdownCallback(ShutdownEvent obj)
        {
            Trace.TraceWarning($"Shutdown found on {obj.Timestamp}");

            Reader.CurrentJournal.State = JournalState.ClosedShutdown;
        }

        public override string Name => "Events";

        internal void Call(string json)
        {
            var eventobject = JsonConvert.DeserializeObject<dynamic>(json);
            var eventname = (string)eventobject.@event;

            PreEventCall?.Invoke(eventname, json);

            if (!_configuration.Exclude.Contains(eventname))
            {
                var modeltype = GetTypeByEventname(eventname);
                if (modeltype != null)
                {
                    Trace.TraceInformation($"Call event - {eventname}");

                    var model = (EventModelBase)JsonConvert.DeserializeObject(json, modeltype, _jsonsettings);
                    EventCall?.Invoke(eventname, model);
                    CallEvent(model);
                }
                else
                {
                    Trace.TraceError($"!!! Unkown event - {eventname}");
                    UnkownEventCall?.Invoke(eventname, json);
                }
            }
            else
            {
                Trace.TraceWarning($"Exclude event - {eventname}");
            }
        }

        public void Subscribe<TModel>(Action<TModel> target)
            where TModel : EventModelBase
        {
            if (!_targets.ContainsKey(typeof(TModel)))
            {
                _targets.Add(typeof(TModel), new HashSet<Delegate>());
            }

            _targets[typeof(TModel)].Add(target);
        }

        private void CallEvent(EventModelBase model)
        {
            foreach (var item in _targets[model.GetType()])
            {
                item.DynamicInvoke(model);
            }
        }

        private Type GetTypeByEventname(string eventname)
        {
            if (_events.TryGetValue(eventname, out Type type))
                return type;
            else
                return null;
        }

        public void DispatchEvent()
        {
            string json = null;

            lock (_queue)
            {
                if (_queue.Count > 0)
                {
                    json = _queue.Dequeue();
                }
            }

            if (json != null)
                Call(json);
        }

        protected override void OnStart()
        {
            Reader.ScanFiles();

            Task.Run(() =>
            {
                while (Running)
                {
                    if (Reader.CurrentJournal == null || Reader.CurrentJournal.State != JournalState.New)
                    {
                        Thread.Sleep(500);
                        Reader.ScanFiles();
                        continue;
                    }

                    if (Reader.CurrentJournal != null && Reader.HasNextChuck())
                    {
                        var json = Reader.NextChuck();

                        if (string.IsNullOrEmpty(json))
                            continue;

                        InsertToQueue(json);
                    }
                }
            });
        }

        internal void InsertToQueue(string json)
        {
            lock (_queue)
            {
                _queue.Enqueue(json);
            }
        }

        public DirectoryInfo JournalDirectory { get; }

        internal JournalReader Reader { get; }

        internal StatusParser StatusParser { get; }

        internal CargoParser CargoParser { get; }
    }
}