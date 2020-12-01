using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class InterdictedEvent : EventModelBase
    {
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
