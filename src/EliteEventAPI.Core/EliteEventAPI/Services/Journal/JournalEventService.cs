using EliteEventAPI.Configuration;
using EliteEventAPI.Diagnostics.Logging;
using EliteEventAPI.Services.Journal.Events;
using EliteEventAPI.Services.Journal.Parser;
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

namespace EliteEventAPI.Services.Journal
{
    public delegate void EventServiceEventDelegate(string eventname, EventModelBase model);
    public delegate void EventServiceJsonDelegate(string eventname, DateTime timestamp, string json);

    public sealed class JournalEventService : ServiceBase
    {
        private readonly DateTime IGNORE_DATE = new DateTime(2019, 1, 1);
        private readonly ClassLogger logger;

        private readonly Queue<string> _queue = new Queue<string>();
        private readonly JournalEventServiceConfiguration _configuration;

        private readonly Dictionary<string, Type> _events = new Dictionary<string, Type>();
        private readonly Dictionary<Type, HashSet<Delegate>> _targets = new Dictionary<Type, HashSet<Delegate>>();
        private readonly JsonSerializerSettings _jsonsettings;

        public event EventServiceJsonDelegate PreEventCall;
        public event EventServiceEventDelegate EventCall;
        public event EventServiceJsonDelegate UnkownEventCall;

        public JournalEventService()
        {
            logger = new ClassLogger(this);

            ScanEvents();

            _jsonsettings = new JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Error,
                Error = new EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs>(JsonErrorEventHandler)
            };

            _configuration = ConfigurationManager.LoadConfiguration<JournalEventServiceConfiguration>();

            //Subscribe<InternalModuleInfoEvent>(InternalModuleInfoCallback);
            //Subscribe<InternalCargoEvent>(InternaCargoCallback);
            //Subscribe<InternalOutfittingEvent>(InternalOutfittingCallback);
            //Subscribe<InternalMarketEvent>(InternalMarketCallback);
            //Subscribe<InternalNavRouteEvent>(InternalNavRouteCallback);
        }

        private void JsonErrorEventHandler(object sender, Newtonsoft.Json.Serialization.ErrorEventArgs e)
        {
            logger.Error($"Json parser error - Object: {e.CurrentObject} Message: { e.ErrorContext.Error.Message}");
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

        public override string Name => "Events";

        public void Call(string json)
        {
            var eventobject = JsonConvert.DeserializeObject<dynamic>(json);
            var eventname = (string)eventobject.@event;
            var timestamp = (DateTime)eventobject.timestamp;

            PreEventCall?.Invoke(eventname, timestamp, json);

            if (timestamp < IGNORE_DATE)
            {
                logger.Error($"Event ignored     : [{timestamp}] {eventname}]");
                return;
            }

            if (!_configuration.Exclude.Contains(eventname))
            {
                var modeltype = GetTypeByEventname(eventname);
                if (modeltype != null)
                {
                    logger.Debug($"Call event       : [{timestamp}] {eventname}");

                    var model = default(EventModelBase);

                    try
                    {
                        model = (EventModelBase)JsonConvert.DeserializeObject(json, modeltype, _jsonsettings);
                    }
                    catch (Exception ex)
                    {
                        logger.Error($"!!! Unkown format : [{timestamp}] {eventname} - {ex.Message}");
                        return;
                    }

                    EventCall?.Invoke(eventname, model);
                    CallEvent(model);
                }
                else
                {
                    logger.Error($"!!! Unkown event : [{timestamp}] {eventname}");
                    UnkownEventCall?.Invoke(eventname, timestamp, json);
                }
            }
            else
            {
                logger.Warning($"Exclude event    : [{timestamp}] {eventname}");
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

        internal void CallEvent(EventModelBase model)
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

        internal void InsertToQueue(string json)
        {
            lock (_queue)
            {
                _queue.Enqueue(json);
            }
        }

        public IEnumerable<string> GetEventNames()
        {
            return _events.Keys.ToArray();
        }

        public IEnumerable<string> GetEventClassnames()
        {
            return _events.Values.Select(m => m.Name).ToArray();
        }

        public IEnumerable<Type> GetEventTypes()
        {
            return _events.Values.ToArray();
        }
    }
}