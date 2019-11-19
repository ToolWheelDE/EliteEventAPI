using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class MarketSellEvent : EventModelBase
    {
        protected internal override string Eventname => "MarketSell";

        [JsonProperty("")]
        public long MarketId { get; internal set; }

        [JsonProperty("")]
        public string Type { get; internal set; }

        [JsonProperty("Type_Localised")]
        public string TypeLocalised { get; internal set; }

        [JsonProperty("")]
        public long Count { get; internal set; }

        [JsonProperty("")]
        public long SellPrice { get; internal set; }

        [JsonProperty("")]
        public long TotalSale { get; internal set; }

        [JsonProperty("")]
        public long AvgPricePaid { get; internal set; }

        [JsonProperty("")]
        public bool StolenGoods { get; internal set; }

        [JsonProperty("")]
        public bool BlackMarket { get; internal set; }
    }
}
