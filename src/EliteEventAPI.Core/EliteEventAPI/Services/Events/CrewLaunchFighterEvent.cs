using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public class CrewLaunchFighterEvent : EventModelBase
    {
        protected internal override string Eventname => "CrewLaunchFighter";

        [JsonProperty]
        public string Crew { get; internal set; }
    }
}
