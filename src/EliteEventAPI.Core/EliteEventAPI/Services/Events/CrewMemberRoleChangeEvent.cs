using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class CrewMemberRoleChangeEvent : EventModelBase
    {
        protected internal override string Eventname => "CrewMemberRoleChange";

        [JsonProperty]
        public string Crew { get; internal set; }

        [JsonProperty]
        public string Role { get; internal set; }
    }
}
