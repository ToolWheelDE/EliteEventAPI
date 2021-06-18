using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class BountyEvent : EventModelBase
    {
        [JsonProperty]
        public Reward[] Rewards { get; internal set; }

        [JsonProperty]
        public string Target { get; internal set; }

        [JsonProperty]
        public long TotalReward { get; internal set; }

        [JsonProperty]
        public string VictimFaction { get; internal set; }

        [JsonProperty]
        public long SharedWithOthers { get; internal set; }
    }
}
