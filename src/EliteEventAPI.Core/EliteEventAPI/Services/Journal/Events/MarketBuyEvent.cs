using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class MarketBuyEvent : EventModelBase
    {
        [JsonProperty]
        public long MarketId { get; internal set; }

        [JsonProperty]
        public string Type { get; internal set; }

        [JsonProperty("Type_Localised")]
        public string TypeLocalised { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }

        [JsonProperty]
        public long BuyPrice { get; internal set; }

        [JsonProperty]
        public long TotalCost { get; internal set; }

    }
}
