using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class InterdictionEvent : EventModelBase
    {
        protected internal override string Eventname => "Interdiction";

        [JsonProperty]
        public bool Success { get; internal set; }

        [JsonProperty]
        public bool IsPlayer { get; internal set; }

        [JsonProperty]
        public string Interdicted { get; internal set; }

        [JsonProperty]
        public string Faction { get; internal set; }

        [JsonProperty]
        public string Power { get; internal set; }
    }
}
