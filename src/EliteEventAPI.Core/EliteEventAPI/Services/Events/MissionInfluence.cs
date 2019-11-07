using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class MissionInfluence
    {
        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public string Trend { get; internal set; }

        [JsonProperty]
        public string Influence { get; internal set; }
    }
}