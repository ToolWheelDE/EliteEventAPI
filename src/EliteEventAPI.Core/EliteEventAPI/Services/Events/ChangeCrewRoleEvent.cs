using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class ChangeCrewRoleEvent : EventModelBase
    {
        protected internal override string Eventname => "ChangeCrewRole";

        [JsonProperty]
        public string Role { get; internal set; }
    }
}
