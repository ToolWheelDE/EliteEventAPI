using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class CrewAssignEvent : EventModelBase
    {
        protected internal override string Eventname => "CrewAssign";

        [JsonProperty("")]
        public string Name { get; internal set; }

        [JsonProperty("")]
        public long CrewId { get; internal set; }

        [JsonProperty("")]
        public string Role { get; internal set; }
    }
}
