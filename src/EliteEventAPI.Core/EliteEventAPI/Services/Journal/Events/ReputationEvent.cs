using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class ReputationEvent : EventModelBase
    {
        [JsonProperty]
        public double Empire { get; internal set; }

        [JsonProperty]
        public double Federation { get; internal set; }

        [JsonProperty]
        public double Independent { get; internal set; }

        [JsonProperty]
        public double Alliance { get; internal set; }
    }
}