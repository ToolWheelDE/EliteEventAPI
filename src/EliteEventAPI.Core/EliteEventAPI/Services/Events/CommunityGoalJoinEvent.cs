using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class CommunityGoalJoinEvent : EventModelBase
    {
        protected internal override string Eventname => "CommunityGoalJoin";

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public string System { get; internal set; }
    }
}
