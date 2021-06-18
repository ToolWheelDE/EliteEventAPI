using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class CommunityGoalRewardEvent : EventModelBase
    {
        [JsonProperty]
        public string Name { get; internal set; }
        [JsonProperty]
        public string System { get; internal set; }
        [JsonProperty]
        public long Reward { get; internal set; }
    }
}
