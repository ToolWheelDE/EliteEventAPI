using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class ChangeCrewRoleEvent : EventModelBase
    {
        [JsonProperty]
        public string Role { get; internal set; }
    }
}
