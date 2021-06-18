using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    /// <summary>
    /// Triggerd on change the ship or docking SRV back in ship. ( Also on startup )
    /// </summary>
    public class LoadoutEvent : EventModelBase
    {
        /// <summary>
        /// Shipname
        /// </summary>
        [JsonProperty]
        public string Ship { get; internal set; }

        /// <summary>
        /// ShipId
        /// </summary>
        [JsonProperty]
        public long ShipId { get; internal set; }

        [JsonProperty]
        public string ShipName { get; internal set; }

        [JsonProperty]
        public string ShipIdent { get; internal set; }

        [JsonProperty]
        public long HullValue { get; internal set; }

        [JsonProperty]
        public double HullHealth { get; internal set; }

        [JsonProperty]
        public long ModulesValue { get; internal set; }

        [JsonProperty]
        public long UnladenMass { get; internal set; }

        [JsonProperty]
        public LoadOutFuel FuelCapacity { get; internal set; }

        [JsonProperty]
        public int CargoCapacity { get; internal set; }

        [JsonProperty]
        public double MaxJumpRange { get; internal set; }

        [JsonProperty]
        public bool Hot { get; internal set; }

        [JsonProperty]
        public long Rebuy { get; internal set; }

        [JsonProperty]
        public ShipModule[] Modules { get; internal set; }
    }
}