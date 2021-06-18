using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    internal sealed class InternalCargoEvent : EventModelBase
    {
        protected internal override string Eventname => "Cargo";

        [JsonProperty]
        public string Vessel { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }

        [JsonProperty]
        public Inventory[] Inventory { get; internal set; }
    }
}
