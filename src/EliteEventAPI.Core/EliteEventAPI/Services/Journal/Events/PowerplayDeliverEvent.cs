using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class PowerplayDeliverEvent : EventModelBase
    {
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
