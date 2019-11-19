using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class CrewMemberQuitsEvent : EventModelBase
    {
        protected internal override string Eventname => "CrewMemberQuits";

        [JsonProperty]
        public string Crew { get; internal set; }
    }
}
