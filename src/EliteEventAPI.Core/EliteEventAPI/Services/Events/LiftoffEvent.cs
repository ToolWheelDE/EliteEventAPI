using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class LiftoffEvent : EventModelBase
    {
        protected internal override string Eventname => "Liftoff";

        [JsonProperty("")]
        public bool PlayerControlled { get; internal set; }

        [JsonProperty("")]
        public double Latitude { get; internal set; }

        [JsonProperty("")]
        public double Longitude { get; internal set; }
    }
}
