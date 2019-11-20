using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public class CrewLaunchFighterEvent : EventModelBase
    {
        [JsonProperty]
        public string Crew { get; internal set; }
    }
}
