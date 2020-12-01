using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class FSSDiscoveryScanEvent : EventModelBase
    {
        [JsonProperty]
        public string StarSystem { get; internal set; }

        [JsonProperty]
        public string SystemName { get; internal set; }

        [JsonProperty]
        public string SystemAddress { get; internal set; }

        [JsonProperty]
        public double Progress { get; internal set; }

        [JsonProperty]
        public int BodyCount { get; internal set; }

        [JsonProperty]
        public int NonBodyCount { get; internal set; }
    }
}