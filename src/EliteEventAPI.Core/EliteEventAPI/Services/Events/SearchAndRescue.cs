using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public class SearchAndRescue
    {
        [JsonProperty("SearchRescue_Traded")]
        public long SearchRescueTraded { get; internal set; }

        [JsonProperty("SearchRescue_Profit")]
        public long SearchRescueProfit { get; internal set; }

        [JsonProperty("SearchRescue_Count")]
        public long SearchRescueCount { get; internal set; }
    }
}