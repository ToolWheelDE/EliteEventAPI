using EliteEventAPI.Services.Journal;
using EliteEventAPI.Services.Journal.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Storage.Models
{
    public sealed class ShipModel : ModelBase
    {
        public ShipModel(JournalEventService eventservice)
        {
            eventservice.Subscribe<StatusEvent>(GameStatusCallback);
            eventservice.Subscribe<DockedEvent>(DockedCallback);
            eventservice.Subscribe<UndockedEvent>(UndockedCallback);
            eventservice.Subscribe<DockingGrantedEvent>(DockingGrantedCallback);
            eventservice.Subscribe<DockingRequestedEvent>(DockingRequestedCallback);
            eventservice.Subscribe<DockingDeniedEvent>(DockingDeniedCallback);
            eventservice.Subscribe<DockingCancelledEvent>(DockingCancelledCallback);
            eventservice.Subscribe<DockingTimeoutEvent>(DockingTimeoutCallback);
            eventservice.Subscribe<LoadGameEvent>(LoadGameCallback);

            eventservice.Subscribe<ShipyardSwapEvent>(ShipyardSwapCallback);
            eventservice.Subscribe<StoredShipsEvent>(StoredShipsCallback);

            SetValue(() => DockingState, DockingStates.Undocked);
            SetValue(() => DockLandingPad, null);
        }

        private void StoredShipsCallback(StoredShipsEvent obj)
        {

        }

        private void ShipyardSwapCallback(ShipyardSwapEvent obj)
        {

        }

        private void LoadGameCallback(LoadGameEvent obj)
        {
            SetValue(() => Shipname, string.IsNullOrEmpty(obj.ShipName) ? obj.Ship : obj.ShipName);
            SetValue(() => ShipIdent, obj.ShipIdent);
            SetValue(() => ShipId, obj.ShipId);
        }

        private void UndockedCallback(UndockedEvent obj)
        {
            SetValue(() => DockingState, DockingStates.Undocked);
            SetValue(() => DockLandingPad, null);
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
        }

        private void GameStatusCallback(StatusEvent obj)
        {
            if (obj.Pips != null)
            {
                SetValue(() => EnergyWeapons, obj.Pips[2]);
                SetValue(() => EnergyEngine, obj.Pips[1]);
                SetValue(() => EnergySystem, obj.Pips[0]);
            }

            if (obj.Heading.HasValue)
            {
                SetValue(() => Heading, obj.Heading.Value);
            }

            if (obj.Fuel != null)
            {
                SetValue(() => FuelReservoir, obj.Fuel.FuelReservoir);
                SetValue(() => FuelMain, obj.Fuel.FuelMain);
            }

            if (obj.LegalState != null)
            {
                SetValue(() => LegalState, (LegalState)Enum.Parse(typeof(LegalState), obj.LegalState));
            }
            else
            {
                SetValue(() => LegalState, LegalState.UnSet);
            }

            SetValue(() => Cargo, obj.Cargo);

            SetValue(() => Docked, obj.Docked);
            SetValue(() => Landed, obj.Landed);
            SetValue(() => Gear, obj.Gear);
            SetValue(() => Shields, obj.Shields);
            SetValue(() => Supercruise, obj.Supercruise);
            SetValue(() => FlightAssist, obj.FlightAssist);
            SetValue(() => Hardpoints, obj.Hardpoints);
            SetValue(() => Winging, obj.Winging);
            SetValue(() => Lights, obj.Lights);
            SetValue(() => CargoScoop, obj.CargoScoop);
            SetValue(() => SilentRunning, obj.SilentRunning);
            SetValue(() => Scooping, obj.Scooping);
            //SetValue(() => SrvHandbreak, obj.SrvHandbreak);
            //SetValue(() => SrvTurrent, obj.SrvTurrent);
            //SetValue(() => SrvNearShip, obj.SrvNearShip);
            //SetValue(() => SrvDriveAssist, obj.SrvDriveAssist);
            SetValue(() => MassLocked, obj.MassLocked);
            SetValue(() => FsdCharging, obj.FsdCharging);
            SetValue(() => FsdCooldown, obj.FsdCooldown);
            SetValue(() => LowFuel, obj.LowFuel);
            SetValue(() => Overheating, obj.Overheating);
            SetValue(() => HasLatlong, obj.HasLatlong);
            SetValue(() => InDanger, obj.InDanger);
            SetValue(() => InInterdiction, obj.InInterdiction);
            SetValue(() => InMothership, obj.InMothership);
            SetValue(() => InFighter, obj.InFighter);
            SetValue(() => InSRV, obj.InSRV);
            SetValue(() => AnalysisMode, obj.AnalysisMode);
            SetValue(() => NightVision, obj.NightVision);
            SetValue(() => HyperJump, obj.HyperJump);
        }

        public string Shipname { get => GetValue(() => Shipname); }

        public string ShipIdent { get => GetValue(() => ShipIdent); }

        public long ShipId { get => GetValue(() => ShipId); }

        public DockingStates DockingState { get => GetValue(() => DockingState); }

        public int? DockLandingPad { get => GetValue(() => DockLandingPad); }

        public double Heading { get; private set; }

        public int EnergyWeapons { get => GetValue(() => EnergyWeapons); }

        public int EnergyEngine { get => GetValue(() => EnergyEngine); }

        public int EnergySystem { get => GetValue(() => EnergySystem); }

        public long FireGroup { get => GetValue(() => FireGroup); }

        public double FuelMain { get => GetValue(() => FuelMain); }

        public double FuelReservoir { get => GetValue(() => FuelReservoir); }

        public LegalState LegalState { get => GetValue(() => LegalState); }

        public long Cargo { get => GetValue(() => Cargo); }

        public bool Docked { get => GetValue(() => Docked); }

        public bool Landed { get => GetValue(() => Landed); }

        public bool Gear { get => GetValue(() => Gear); }

        public bool Shields { get => GetValue(() => Shields); }

        public bool Supercruise { get => GetValue(() => Supercruise); }

        public bool FlightAssist { get => GetValue(() => FlightAssist); }

        public bool Hardpoints { get => GetValue(() => Hardpoints); }

        public bool Winging { get => GetValue(() => Winging); }

        public bool Lights { get => GetValue(() => Lights); }

        public bool CargoScoop { get => GetValue(() => CargoScoop); }

        public bool SilentRunning { get => GetValue(() => SilentRunning); }

        public bool Scooping { get => GetValue(() => Scooping); }

        //public bool SrvHandbreak { get => GetValue(() => SrvHandbreak); }

        //public bool SrvTurrent { get => GetValue(() => SrvTurrent); }

        //public bool SrvNearShip { get => GetValue(() => SrvNearShip); }

        //public bool SrvDriveAssist { get => GetValue(() => SrvDriveAssist); }

        public bool MassLocked { get => GetValue(() => MassLocked); }

        public bool FsdCharging { get => GetValue(() => FsdCharging); }

        public bool FsdCooldown { get => GetValue(() => FsdCooldown); }

        public bool LowFuel { get => GetValue(() => LowFuel); }

        public bool Overheating { get => GetValue(() => Overheating); }

        public bool HasLatlong { get => GetValue(() => HasLatlong); }

        public bool InDanger { get => GetValue(() => InDanger); }

        public bool InInterdiction { get => GetValue(() => InInterdiction); }

        public bool InMothership { get => GetValue(() => InMothership); }

        public bool InFighter { get => GetValue(() => InFighter); }

        public bool InSRV { get => GetValue(() => InSRV); }

        public bool AnalysisMode { get => GetValue(() => AnalysisMode); }

        public bool NightVision { get => GetValue(() => NightVision); }

        public bool HyperJump { get => GetValue(() => HyperJump); }
    }
}
