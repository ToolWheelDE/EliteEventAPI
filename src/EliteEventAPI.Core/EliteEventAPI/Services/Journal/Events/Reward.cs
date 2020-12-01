using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class Reward
    {
        [JsonProperty]
        public string Faction { get; internal set; }

        [JsonProperty("Reward")]
        public long RewardValue { get; internal set; }
    }
}