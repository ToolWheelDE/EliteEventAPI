using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class MarketItem
    {
        [JsonProperty("id")]
        public string ID { get; internal set; }

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; internal set; }

        [JsonProperty]
        public string Category { get; internal set; }

        [JsonProperty("Category_Localised")]
        public string CategoryLocalised { get; internal set; }

        [JsonProperty]
        public string BuyPrice { get; internal set; }

        [JsonProperty]
        public string SellPrice { get; internal set; }

        [JsonProperty]
        public string MeanPrice { get; internal set; }

        [JsonProperty]
        public string StockBracket { get; internal set; }

        [JsonProperty]
        public string DemandBracket { get; internal set; }

        [JsonProperty]
        public string Stock { get; internal set; }

        [JsonProperty]
        public string Demand { get; internal set; }

        [JsonProperty]
        public string Consumer { get; internal set; }

        [JsonProperty]
        public string Producer { get; internal set; }

        [JsonProperty]
        public string Rare { get; internal set; }
    }
}