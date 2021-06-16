using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class CrewMemberRoleChangeEvent : EventModelBase
    {
        [JsonProperty]
        public string Crew { get; internal set; }

        [JsonProperty]
        public string Role { get; internal set; }
    }
}
