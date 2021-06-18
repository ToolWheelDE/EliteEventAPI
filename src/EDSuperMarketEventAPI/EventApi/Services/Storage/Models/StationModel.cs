using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal;
using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Storage.Models
{
    public sealed class StationModel : ModelBase
    {
        public StationModel(JournalEventService eventservice)
        {
            eventservice.Subscribe<LocationEvent>(LocationCallback);
            eventservice.Subscribe<DockedEvent>(DockedCallback);
            eventservice.Subscribe<UndockedEvent>(UndockedCallback);
            eventservice.Subscribe<DockingGrantedEvent>(DockingGrantedCallback);
            eventservice.Subscribe<DockingRequestedEvent>(DockingRequestedCallback);
            eventservice.Subscribe<DockingDeniedEvent>(DockingDeniedCallback);
            eventservice.Subscribe<DockingCancelledEvent>(DockingCancelledCallback);
            eventservice.Subscribe<DockingTimeoutEvent>(DockingTimeoutCallback);

            SetValue(() => DockingState, DockingStates.Undocked);
            SetValue(() => DockLandingPad, null);
        }

        private void LocationCallback(LocationEvent obj)
        {
            if (obj.Docked)
            {
                SetValue(() => DockingState, DockingStates.Docked);
                SetValue(() => CurrentStationname, obj.StationName);
                SetValue(() => CurrentStationMarketId, obj.MarketID);
            }
            else
            {
                SetValue(() => DockingState, DockingStates.Undocked);
                SetValue(() => CurrentStationname, "");
                SetValue(() => CurrentStationMarketId, 0);
            }
        }

        private void UndockedCallback(UndockedEvent obj)
        {
            SetValue(() => DockingState, DockingStates.Undocked);
            SetValue(() => DockLandingPad, null);
            SetValue(() => CurrentStationname, "");
            SetValue(() => CurrentStationMarketId, null);
        }

        private void DockingTimeoutCallback(DockingTimeoutEvent obj)
        {
            SetValue(() => DockingState, DockingStates.Timeout);
            SetValue(() => DockLandingPad, null);
        }

        private void DockingCancelledCallback(DockingCancelledEvent obj)
        {
            SetValue(() => DockingState, DockingStates.Cancelled);
            SetValue(() => DockLandingPad, null);
        }

        private void DockingDeniedCallback(DockingDeniedEvent obj)
        {
            SetValue(() => DockingState, DockingStates.Denied);
            SetValue(() => DockLandingPad, null);
        }

        private void DockingRequestedCallback(DockingRequestedEvent obj)
        {
            SetValue(() => DockingState, DockingStates.Requested);
            SetValue(() => DockLandingPad, null);
        }

        private void DockingGrantedCallback(DockingGrantedEvent obj)
        {
            SetValue(() => DockingState, DockingStates.Granted);
            SetValue(() => DockLandingPad, obj.LandingPad);
        }

        private void DockedCallback(DockedEvent obj)
        {
            SetValue(() => DockingState, DockingStates.Docked);
            SetValue(() => CurrentStationname, obj.StationName);
            SetValue(() => CurrentStationMarketId, obj.MarketId);
        }

        public DockingStates DockingState { get => GetValue(() => DockingState); }

        public int? DockLandingPad { get => GetValue(() => DockLandingPad); }

        public bool Docked { get => GetValue(() => Docked); }

        public string CurrentStationname { get => GetValue(() => CurrentStationname); }

        public long? CurrentStationMarketId { get => GetValue(() => CurrentStationMarketId); }
    }
}
