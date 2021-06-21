using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class CrimeStatistic
    {
        [JsonProperty("Notoriety", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long Notoriety { get; internal set; }

        [JsonProperty("Fines", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long Fines { get; internal set; }

        [JsonProperty("Total_Fines", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long TotalFines { get; internal set; }

        [JsonProperty("Bounties_Received", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long BountiesReceived { get; internal set; }

        [JsonProperty("Total_Bounties", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long TotalBounties { get; internal set; }

        [JsonProperty("Highest_Bounty", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long HighestBounty { get; internal set; }

        [JsonProperty("Malware_Uploaded", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long Malware_Uploaded { get; internal set; }

        [JsonProperty("Settlements_State_Shutdown", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SettlementsStateShutdown { get; internal set; }

        [JsonProperty("Production_Sabotage", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long ProductionSabotage { get; internal set; }

        [JsonProperty("Production_Theft", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long ProductionTheft { get; internal set; }

        [JsonProperty("Total_Murders", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long TotalMurders { get; internal set; }

        [JsonProperty("Citizens_Murdered", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long CitizensMurdered { get; internal set; }

        [JsonProperty("Omnipol_Murdered", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long OmnipolMurdered { get; internal set; }

        [JsonProperty("Guards_Murdered", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long GuardsMurdered { get; internal set; }

        [JsonProperty("Data_Stolen", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long DataStolen { get; internal set; }

        [JsonProperty("Goods_Stolen", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long GoodsStolen { get; internal set; }

        [JsonProperty("Sample_Stolen", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SampleStolen { get; internal set; }

        [JsonProperty("Total_Stolen", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long TotalStolen { get; internal set; }

        [JsonProperty("Turrets_Destroyed", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long TurretsDestroyed { get; internal set; }

        [JsonProperty("Turrets_Overloaded", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long TurretsOverloaded { get; internal set; }

        [JsonProperty("Turrets_Total", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long TurretsTotal { get; internal set; }

        [JsonProperty("Value_Stolen_StateChange", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long Value_StolenStateChange { get; internal set; }

        [JsonProperty("Profiles_Cloned", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long ProfilesCloned { get; internal set; }
    }
}