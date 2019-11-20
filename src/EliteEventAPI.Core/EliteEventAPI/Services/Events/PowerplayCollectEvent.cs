using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class PowerplayCollectEvent : EventModelBase
    {
        protected internal override string Eventname => "PowerplayCollect";

        [JsonProperty]
        public string Power { get; internal set; }

        [JsonProperty]
        public string Type { get; internal set; }

        [JsonProperty("Type_Localised")]
        public string TypeLocalised { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }
    }
}
