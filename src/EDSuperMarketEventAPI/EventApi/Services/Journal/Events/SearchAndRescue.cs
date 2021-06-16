using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
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