using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class FSDTargetEvent : EventModelBase
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public string StarClass { get; internal set; }

        [JsonProperty]
        public int RemainingJumpsInRoute { get; internal set; }
    }
}