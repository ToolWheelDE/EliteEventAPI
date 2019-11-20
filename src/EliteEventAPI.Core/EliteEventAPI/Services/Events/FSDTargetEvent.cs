using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class FSDTargetEvent : EventModelBase
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public int RemainingJumpsInRoute { get; internal set; }
    }
}