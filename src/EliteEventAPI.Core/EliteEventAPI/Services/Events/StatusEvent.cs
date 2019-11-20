using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteEventAPI.Services.Events
{
    public class StatusEvent : EventModelBase
    {
        [JsonProperty]
        public ShipStatusFlags Flags { get; internal set; }

        [JsonProperty]
        public int[] Pips { get; internal set; }

        [JsonProperty]
        public int FireGroup { get; internal set; }

        [JsonProperty]
        public int GuiFocus { get; internal set; }

        [JsonProperty]
        public StatusFuel Fuel { get; internal set; }

        [JsonProperty]
        public string LegalState { get; internal set; }

        [JsonProperty]
        public double? Latitude { get; internal set; }

        [JsonProperty]
        public double? Longitude { get; internal set; }

        [JsonProperty]
        public double? Altitude { get; internal set; }

        [JsonProperty]
        public double? Heading { get; internal set; }

        [JsonProperty]
        public string BodyName { get; internal set; }

        [JsonProperty]
        public double? PlanetRadius { get; internal set; }

        [JsonProperty]
        public long Cargo { get; internal set; }

        public bool Docked { get { return GetFlag(0); } }

        public bool Landed { get { return GetFlag(1); } }

        public bool Gear { get { return GetFlag(2); } }

        public bool Shields { get { return GetFlag(3); } }

        public bool Supercruise { get { return GetFlag(4); } }

        public bool FlightAssist { get { return !GetFlag(5); } }

        public bool Hardpoints { get { return GetFlag(6); } }

        public bool Winging { get { return GetFlag(7); } }

        public bool Lights { get { return GetFlag(8); } }

        public bool CargoScoop { get { return GetFlag(9); } }

        public bool SilentRunning { get { return GetFlag(10); } }

        public bool Scooping { get { return GetFlag(11); } }

        public bool SrvHandbreak { get { return GetFlag(12); } }

        public bool SrvTurrent { get { return GetFlag(13); } }

        public bool SrvNearShip { get { return GetFlag(14); } }

        public bool SrvDriveAssist { get { return GetFlag(15); } }

        public bool MassLocked { get { return GetFlag(16); } }

        public bool FsdCharging { get { return GetFlag(17); } }

        public bool FsdCooldown { get { return GetFlag(18); } }

        public bool LowFuel { get { return GetFlag(19); } }

        public bool Overheating { get { return GetFlag(20); } }

        public bool HasLatlong { get { return GetFlag(21); } }

        public bool InDanger { get { return GetFlag(22); } }

        public bool InInterdiction { get { return GetFlag(23); } }

        public bool InMothership { get { return GetFlag(24); } }

        public bool InFighter { get { return GetFlag(25); } }

        public bool InSRV { get { return GetFlag(26); } }

        public bool AnalysisMode { get { return GetFlag(27); } }

        public bool NightVision { get { return GetFlag(28); } }

        public bool HyperJump { get { return GetFlag(30); } }

        public bool IsRunning { get { return (Flags != 0); } }

        public bool GetFlag(int bit)
        {
            return Flags.HasFlag((ShipStatusFlags)(1 << bit));
        }
    }
}
