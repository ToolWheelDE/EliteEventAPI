using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class MarketSellEvent : EventModelBase
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
        public long SellPrice { get; internal set; }

        [JsonProperty]
        public long TotalSale { get; internal set; }

        [JsonProperty]
        public long AvgPricePaid { get; internal set; }

        [JsonProperty]
        public bool StolenGoods { get; internal set; }

        [JsonProperty]
        public bool BlackMarket { get; internal set; }
    }
}
