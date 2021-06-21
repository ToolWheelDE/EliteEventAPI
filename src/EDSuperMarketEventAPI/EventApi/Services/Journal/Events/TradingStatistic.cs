using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class TradingStatistic
    {
        [JsonProperty("Markets_Traded_With")]
        public long MarketsTradedWith { get; internal set; }

        [JsonProperty("Market_Profits")]
        public long MarketProfits { get; internal set; }

        [JsonProperty("Resources_Traded")]
        public long ResourcesTraded { get; internal set; }

        [JsonProperty("Average_Profit")]
        public double AverageProfit { get; internal set; }

        [JsonProperty("Highest_Single_Transaction")]
        public long HighestSingleTransaction { get; internal set; }

        [JsonProperty("Data_Sold", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long Data_Sold { get; internal set; }

        [JsonProperty("Goods_Sold", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long		Goods_Sold   {get;internal set;}

        [JsonProperty("Assets_Sold", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long		Assets_Sold  {get;internal set;}
    }
}