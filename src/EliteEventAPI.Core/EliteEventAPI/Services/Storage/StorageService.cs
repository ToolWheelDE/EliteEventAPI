using EliteEventAPI.Configuration;
using EliteEventAPI.Services;
using EliteEventAPI.Services.Events;
using EliteEventAPI.Services.Storage.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace EliteEventAPI.Services.Storage
{
    public sealed class StorageService : ServiceBase
    {
        public StorageService()
        {
            EventService = ServiceController.GetService<EventService>();
            EventService.Subscribe<StatusEvent>(GameStatusCallback);

            EventService.PreEventCall += EventService_PreEventCall;

            Game = new GameModel(EventService);
            Commander = new CommanderModel(EventService);
            Navigation = new NavigationModel(EventService);
            StarSystem = new StarSystemModel(EventService);
            Ship = new ShipModel(EventService);
            Missions = new MissionsModel(EventService);
        }

        private void EventService_PreEventCall(string eventname, DateTime timestamp, string json)
        {
            CurrentEvent = eventname;
            CurrentEventTimeStamp = timestamp;
        }

        private void GameStatusCallback(StatusEvent obj)
        {
            JournalSystemRunning = obj.IsRunning;
        }

        public override string Name => "Storage";

        public bool JournalSystemRunning { get; private set; }

        public EventService EventService { get; }

        public GameModel Game { get; }

        public CommanderModel Commander { get; }

        public NavigationModel Navigation { get; }

        public StarSystemModel StarSystem { get; }

        public ShipModel Ship { get; }

        public MissionsModel Missions { get; }

        public string CurrentEvent { get; private set; }

        public DateTime CurrentEventTimeStamp { get; private set; }
    }
}
