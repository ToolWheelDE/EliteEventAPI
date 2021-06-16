using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class ShipModule
    {
        [JsonProperty]
        public string Slot { get; internal set; }

        [JsonProperty]
        public string Item { get; internal set; }

        [JsonProperty]
        public bool On { get; internal set; }

        [JsonProperty]
        public long Priority { get; internal set; }

        [JsonProperty("AmmoInClip", NullValueHandling = NullValueHandling.Ignore)]
        public long? AmmoInClip { get; internal set; }

        [JsonProperty("AmmoInHopper", NullValueHandling = NullValueHandling.Ignore)]
        public long? AmmoInHopper { get; internal set; }

        [JsonProperty]
        public double Health { get; internal set; }

        [JsonProperty("Value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; internal set; }

        [JsonProperty("Engineering", NullValueHandling = NullValueHandling.Ignore)]
        public Engineering Engineering { get; internal set; }
    }
}
