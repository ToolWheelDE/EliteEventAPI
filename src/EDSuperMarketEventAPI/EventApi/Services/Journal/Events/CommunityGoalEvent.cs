using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class CommunityGoalEvent : EventModelBase
    {
        [JsonProperty]
        public CurrentGoal[] CurrentGoals { get; internal set; }
    }
}
