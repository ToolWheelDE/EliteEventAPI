using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class FSSAllBodiesFoundEvent : EventModelBase
    {
        [JsonProperty]
        public string SystemName { get; internal set; }

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }
    }
}