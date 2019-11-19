using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class CrewMemberJoinsEvent : EventModelBase
    {
        protected internal override string Eventname => "CrewMemberJoins";

        [JsonProperty]
        public string Crew { get; internal set; }
    }
}
