using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class FSSDiscoveryScanEvent : EventModelBase
    {
        public override string Eventname => "FSSDiscoveryScan";

        [JsonProperty]
        public string StarSystem { get; internal set; }

        [JsonProperty]
        public string SystemName { get; internal set; }

        [JsonProperty]
        public string SystemAddress { get; internal set; }

        [JsonProperty]
        public double Progress { get; internal set; }

        [JsonProperty]
        public long BodyCount { get; internal set; }

        [JsonProperty]
        public long NonBodyCount { get; internal set; }
    }
}