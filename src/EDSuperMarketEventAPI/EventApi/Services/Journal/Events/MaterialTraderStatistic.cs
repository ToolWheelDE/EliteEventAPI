using Newtonsoft.Json;
using System;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class MaterialTraderStatistic
    {
        [JsonProperty("Trades_Completed", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long TradesCompleted { get; internal set; }

        [JsonProperty("Materials_Traded", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long MaterialsTraded { get; internal set; }

        [Obsolete("Not found in newer journal files.")]
        [JsonProperty("Encoded_Materials_Traded", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long EncodedMaterialsTraded { get; internal set; }

        [Obsolete("Not found in newer journal files.")]
        [JsonProperty("Raw_Materials_Traded", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long RawMaterialsTraded { get; internal set; }

        [Obsolete("Not found in newer journal files.")]
        [JsonProperty("Grade_1_Materials_Traded", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long Grade1MaterialsTraded { get; internal set; }

        [Obsolete("Not found in newer journal files.")]
        [JsonProperty("Grade_2_Materials_Traded", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long Grade2MaterialsTraded { get; internal set; }

        [Obsolete("Not found in newer journal files.")]
        [JsonProperty("Grade_3_Materials_Traded", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long Grade3MaterialsTraded { get; internal set; }

        [Obsolete("Not found in newer journal files.")]
        [JsonProperty("Grade_4_Materials_Traded", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long Grade4MaterialsTraded { get; internal set; }

        [Obsolete("Not found in newer journal files.")]
        [JsonProperty("Grade_5_Materials_Traded", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long Grade5MaterialsTraded { get; internal set; }

        [JsonProperty("Assets_Traded_In", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long AssetsTradedIn { get; internal set; }

        [JsonProperty("Assets_Traded_Out", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long AssetsTradedOut {get;internal set;}
    }
}