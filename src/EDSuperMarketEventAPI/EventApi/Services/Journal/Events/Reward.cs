using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class Reward
    {
        [JsonProperty]
        public string Faction { get; internal set; }

        [JsonProperty("Reward")]
        public long RewardValue { get; internal set; }
    }
}