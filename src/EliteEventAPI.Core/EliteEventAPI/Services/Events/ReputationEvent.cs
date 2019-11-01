using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class ReputationEvent : EventModelBase
    {
        public override string Eventname => "Reputation";

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