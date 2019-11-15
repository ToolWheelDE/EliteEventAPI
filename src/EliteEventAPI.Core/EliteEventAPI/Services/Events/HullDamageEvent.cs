using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class HullDamageEvent : EventModelBase
    {
        protected internal override string Eventname => "HullDamage";

        [JsonProperty]
        public double Health { get; internal set; }

        [JsonProperty]
        public bool PlayerPilot { get; internal set; }

        [JsonProperty]
        public bool Fighter { get; internal set; }
    }
}
