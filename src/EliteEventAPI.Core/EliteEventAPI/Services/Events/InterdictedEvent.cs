using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class InterdictedEvent : EventModelBase
    {
        protected internal override string Eventname => "Interdicted";

        [JsonProperty]
        public bool Submitted { get; internal set; }

        [JsonProperty]
        public string Interdictor { get; internal set; }

        [JsonProperty("Interdictor_Localised")]
        public string InterdictorLocalised { get; internal set; }

        [JsonProperty]
        public bool IsPlayer { get; internal set; }

        [JsonProperty]
        public string Faction { get; internal set; }
    }
}
