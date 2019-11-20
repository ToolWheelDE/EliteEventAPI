using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class ModuleSwapEvent : EventModelBase
    {
        [JsonProperty]
        public long MarketId { get; internal set; }

        [JsonProperty]
        public string FromSlot { get; internal set; }

        [JsonProperty]
        public string ToSlot { get; internal set; }

        [JsonProperty]
        public string FromItem { get; internal set; }

        [JsonProperty("FromItem_Localised")]
        public string FromItemLocalised { get; internal set; }

        [JsonProperty]
        public string ToItem { get; internal set; }

        [JsonProperty("ToItem_Localised")]
        public string ToItemLocalised { get; internal set; }

        [JsonProperty]
        public string Ship { get; internal set; }

        [JsonProperty]
        public long ShipId { get; internal set; }
    }
}
