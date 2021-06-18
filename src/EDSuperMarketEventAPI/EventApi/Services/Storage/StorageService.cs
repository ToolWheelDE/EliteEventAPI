using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal;
using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events;
using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Storage.Models;
using System;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Storage
{
    public sealed class StorageService : ServiceBase
    {
        private JournalEventService eventService;

        public StorageService()
        {
            eventService = ServiceController.GetService<JournalEventService>();
            eventService.PreEventCall += EventService_PreEventCall;
            eventService.Subscribe<StatusEvent>(GameStatusCallback);


            Game = new GameModel(eventService);
            Commander = new CommanderModel(eventService);
            Navigation = new NavigationModel(eventService);
            StarSystem = new StarSystemModel(eventService);
            Ship = new ShipModel(eventService);
            Station = new StationModel(eventService);
            //Missions = new MissionsModel(eventService);
        }

        public override string Name => "Storage";

        private void EventService_PreEventCall(string eventname, DateTime timestamp, string json)
        {
            CurrentEvent = eventname;
            CurrentEventTimeStamp = timestamp;
        }

        private void GameStatusCallback(StatusEvent obj)
        {
            JournalSystemRunning = obj.IsRunning;
        }

        public bool JournalSystemRunning { get; private set; }

        public string CurrentEvent { get; private set; }

        public DateTime CurrentEventTimeStamp { get; private set; }

        public object EventService { get; }

        public GameModel Game { get; }

        public CommanderModel Commander { get; }

        public NavigationModel Navigation { get; }

        public StarSystemModel StarSystem { get; }

        public ShipModel Ship { get; }

        public StationModel Station { get; }
    }
}
