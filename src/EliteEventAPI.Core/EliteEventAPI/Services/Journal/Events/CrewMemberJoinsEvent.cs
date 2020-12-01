using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class CrewMemberJoinsEvent : EventModelBase
    {
        [JsonProperty]
        public string Crew { get; internal set; }
    }
}
