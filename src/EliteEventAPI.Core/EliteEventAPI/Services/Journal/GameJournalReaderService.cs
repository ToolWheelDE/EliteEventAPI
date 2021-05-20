using EliteEventAPI.Services.Journal.Events;
using EliteEventAPI.Services.Journal.Parser;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EliteEventAPI.Services.Journal
{
    public sealed class GameJournalReaderService : ServiceBase
    {
        private readonly DirectoryInfo journalDirectory;
        private readonly JournalReader journalReader;
        private readonly StatusParser statusParser;

        public GameJournalReaderService()
        {
            journalDirectory = new DirectoryInfo(Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "saved games", "Frontier Developments", "Elite Dangerous"));
            journalReader = new JournalReader(journalDirectory);
            EventService = ServiceController.GetService<JournalEventService>();
            statusParser = new StatusParser(journalDirectory);
            statusParser.GameStatusChanged += delegate (string json) { EventService.Call(json); };

            EventService.Subscribe<InternalModuleInfoEvent>(InternalModuleInfoCallback);
            EventService.Subscribe<InternalCargoEvent>(InternaCargoCallback);
            EventService.Subscribe<InternalOutfittingEvent>(InternalOutfittingCallback);
            EventService.Subscribe<InternalMarketEvent>(InternalMarketCallback);
            EventService.Subscribe<InternalNavRouteEvent>(InternalNavRouteCallback);
            EventService.Subscribe<InternalCargoEvent>(InternaBackPackCallback);
            EventService.Subscribe<ShutdownEvent>(InternalShutdownCallback);
        }
          
        private void InternalShutdownCallback(ShutdownEvent obj)
        {
            journalReader.CurrentJournal.State = JournalFileState.Closed;

            journalReader.ScanFiles();
        }

        private void InternaBackPackCallback(InternalCargoEvent obj)
        {
            var file = new FileInfo(Path.Combine(JournalDirectory, "Backpack.json"));
            if (file.Exists)
            {
                using (var reader = new StreamReader(file.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
                {
                    var json = reader.ReadToEnd();
                    var eventobject = JsonConvert.DeserializeObject<BackPackEvent>(json);

                    EventService.CallEvent(eventobject);
                }
            }
        }

        public JournalEventService EventService { get; }

        public override string Name => "JournalReaderService";

        public string JournalDirectory { get => journalDirectory.FullName; }

        public void DispatchEvent()
        {
            EventService.DispatchEvent();
        }

        protected internal override void OnInitialize()
        {
            base.OnInitialize();
        }

        protected override void OnStart()
        {
            journalReader.ScanFiles();

            Task.Run(() =>
            {
                while (Running)
                {
                    if (journalReader.CurrentJournal == null || journalReader.CurrentJournal.State != JournalFileState.Progress)
                    {
                        Thread.Sleep(500);
                        journalReader.ScanFiles();
                        continue;
                    }

                    if (journalReader.CurrentJournal != null && journalReader.HasNextChuck())
                    {
                        var json = journalReader.NextChuck();

                        if (string.IsNullOrEmpty(json))
                            continue;

                        EventService.InsertToQueue(json);
                    }
                }
            });
        }

        protected override void OnStop()
        {
            base.OnStop();
        }

        #region Internal Events by additional files

        private void InternalMarketCallback(InternalMarketEvent obj)
        {
            var file = new FileInfo(Path.Combine(JournalDirectory, "market.json"));
            if (file.Exists)
            {
                using (var reader = new StreamReader(file.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
                {
                    var json = reader.ReadToEnd();
                    var eventobject = JsonConvert.DeserializeObject<MarketEvent>(json);

                    EventService.CallEvent(eventobject);
                }
            }
        }

        private void InternalOutfittingCallback(InternalOutfittingEvent obj)
        {
            var file = new FileInfo(Path.Combine(JournalDirectory, "outfitting.json"));
            if (file.Exists)
            {
                using (var reader = new StreamReader(file.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
                {
                    var json = reader.ReadToEnd();
                    var eventobject = JsonConvert.DeserializeObject<OutfittingEvent>(json);

                    EventService.CallEvent(eventobject);
                }
            }
        }

        private void InternaCargoCallback(InternalCargoEvent obj)
        {
            if (obj.Inventory == null)
            {
                var file = new FileInfo(Path.Combine(JournalDirectory, "cargo.json"));
                if (file.Exists)
                {
                    using (var reader = new StreamReader(file.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
                    {
                        var json = reader.ReadToEnd();
                        var eventobject = JsonConvert.DeserializeObject<CargoEvent>(json);

                        EventService.CallEvent(eventobject);
                    }
                }
            }
            else
            {
                var cargoobject = new CargoEvent()
                {
                    Event = obj.Event,
                    Timestamp = obj.Timestamp,
                    Count = obj.Count,
                    Vessel = obj.Vessel,
                    Inventory = obj.Inventory
                };

                EventService.CallEvent(cargoobject);
            }
        }

        private void InternalModuleInfoCallback(InternalModuleInfoEvent obj)
        {
            var file = new FileInfo(Path.Combine(JournalDirectory, "modulesinfo.json"));
            if (file.Exists)
            {
                using (var reader = new StreamReader(file.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
                {
                    var json = reader.ReadToEnd();
                    var eventobject = JsonConvert.DeserializeObject<ModuleInfoEvent>(json);

                    EventService.CallEvent(eventobject);
                }
            }
        }

        private void InternalNavRouteCallback(InternalNavRouteEvent obj)
        {
            var file = new FileInfo(Path.Combine(JournalDirectory, "navroute.json"));
            if (file.Exists)
            {
                using (var reader = new StreamReader(file.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
                {
                    var json = reader.ReadToEnd();
                    var eventobject = JsonConvert.DeserializeObject<NavRouteEvent>(json);

                    EventService.CallEvent(eventobject);
                }
            }
        }

        #endregion
    }
}
