using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class CommunityGoalRewardEvent : EventModelBase
    {
        protected internal override string Eventname => "CommunityGoalReward";

        [JsonProperty]
        public string Name { get; internal set; }
        [JsonProperty]
        public string System { get; internal set; }
        [JsonProperty]
        public long Reward { get; internal set; }
    }
}
