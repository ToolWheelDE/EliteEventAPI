using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class SearchAndRescueStatistic
    {
        [JsonProperty("SearchRescue_Traded", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SearchRescueTraded { get; internal set; }

        [JsonProperty("SearchRescue_Profit", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SearchRescueProfit { get; internal set; }

        [JsonProperty("SearchRescue_Count", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SearchRescueCount { get; internal set; }

        [JsonProperty("Salvage_Legal_POI", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SalvageLegalPOI { get; internal set; }

        [JsonProperty("Salvage_Legal_Settlements", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SalvageLegalSettlements { get; internal set; }

        [JsonProperty("Salvage_Illegal_POI", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SalvageIllegalPOI { get; internal set; }

        [JsonProperty("Salvage_Illegal_Settlements", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SalvageIllegalSettlements { get; internal set; }

        [JsonProperty("Maglocks_Opened", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long MaglocksOpened { get; internal set; }

        [JsonProperty("Panels_Opened", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long PanelsOpened { get; internal set; }

        [JsonProperty("Settlements_State_FireOut", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SettlementsStateFireOut { get; internal set; }

        [JsonProperty("Settlements_State_Reboot", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SettlementsStateReboot { get; internal set; }
    }
}