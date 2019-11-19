using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class CrewFireEvent : EventModelBase
    {
        protected internal override string Eventname => "CrewFire";

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long CrewId { get; internal set; }
    }
}
