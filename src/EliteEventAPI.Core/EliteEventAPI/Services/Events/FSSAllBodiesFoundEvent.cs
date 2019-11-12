using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class FSSAllBodiesFoundEvent : EventModelBase
    {
        protected internal override string Eventname => "FSSAllBodiesFound";

        [JsonProperty]
        public string SystemName { get; internal set; }

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }
    }
}