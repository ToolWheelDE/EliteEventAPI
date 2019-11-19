using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class DiedEvent : EventModelBase
    {
        protected internal override string Eventname => "Died";

        [JsonProperty]
        public string KillerName { get; internal set; }

        [JsonProperty("KillerName_Localised")]
        public string KillerNameLocalised { get; internal set; }

        [JsonProperty]
        public string KillerShip { get; internal set; }

        [JsonProperty]
        public string KillerRank { get; internal set; }
    }
}
