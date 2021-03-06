﻿using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class SmugglingStatistic
    {
        [JsonProperty("Black_Markets_Traded_With")]
        public long BlackMarketsTradedWith { get; internal set; }

        [JsonProperty("Black_Markets_Profits")]
        public long BlackMarketsProfits { get; internal set; }

        [JsonProperty("Resources_Smuggled")]
        public long ResourcesSmuggled { get; internal set; }

        [JsonProperty("Average_Profit")]
        public double AverageProfit { get; internal set; }

        [JsonProperty("Highest_Single_Transaction")]
        public long HighestSingleTransaction { get; internal set; }
    }
}