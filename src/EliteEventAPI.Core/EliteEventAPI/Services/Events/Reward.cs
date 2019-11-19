using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class Reward
    {
        [JsonProperty]
        public string Faction { get; internal set; }

        [JsonProperty]
        public long RewardReward { get; internal set; }
    }
}