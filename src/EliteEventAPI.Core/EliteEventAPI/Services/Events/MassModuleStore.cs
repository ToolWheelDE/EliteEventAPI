using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class MassModuleStoreEvent : EventModelBase
    {
        protected internal override string Eventname => "MassModuleStore";

        [JsonProperty]
        public long MarketId { get; internal set; }

        [JsonProperty]
        public string Ship { get; internal set; }

        [JsonProperty]
        public long ShipId { get; internal set; }

        [JsonProperty]
        public Item[] Items { get; internal set; }
    }
}