using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class DiedEvent : EventModelBase
    {
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
