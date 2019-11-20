using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class CommunityGoalEvent : EventModelBase
    {
        [JsonProperty]
        public CurrentGoal[] CurrentGoals { get; internal set; }
    }
}
