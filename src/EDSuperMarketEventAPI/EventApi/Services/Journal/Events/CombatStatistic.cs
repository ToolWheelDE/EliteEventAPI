using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class CombatStatistic
    {
        [JsonProperty("Bounties_Claimed", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long BountiesClaimed { get; internal set; }

        [JsonProperty("Bounty_Hunting_Profit", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public double BountyHuntingProfit { get; internal set; }

        [JsonProperty("Combat_Bonds", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long CombatBonds { get; internal set; }

        [JsonProperty("Combat_Bond_Profits", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long CombatBondProfits { get; internal set; }

        [JsonProperty("Assassinations", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long Assassinations { get; internal set; }

        [JsonProperty("Assassination_Profits", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long AssassinationProfits { get; internal set; }

        [JsonProperty("Highest_Single_Reward", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long HighestSingleReward { get; internal set; }

        [JsonProperty("Skimmers_Killed", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SkimmersKilled { get; internal set; }

        [JsonProperty("Dropships_Taken", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long DropshipsTaken { get; internal set; }

        [JsonProperty("Dropships_Booked", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long DropshipsBooked { get; internal set; }

        [JsonProperty("Dropships_Cancelled", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long DropshipsCancelled { get; internal set; }

        [JsonProperty("ConflictZone_High", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long ConflictZoneHigh { get; internal set; }

        [JsonProperty("ConflictZone_Medium", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long ConflictZoneMedium { get; internal set; }

        [JsonProperty("ConflictZone_Low", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long ConflictZoneLow { get; internal set; }

        [JsonProperty("ConflictZone_Total", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long ConflictZoneTotal { get; internal set; }

        [JsonProperty("ConflictZone_High_Wins", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long ConflictZoneHighWins { get; internal set; }

        [JsonProperty("ConflictZone_Medium_Wins", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long ConflictZoneMediumWins { get; internal set; }

        [JsonProperty("ConflictZone_Low_Wins", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long ConflictZoneLowWins { get; internal set; }

        [JsonProperty("ConflictZone_Total_Wins", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long ConflictZoneTotalWins { get; internal set; }

        [JsonProperty("Settlement_Defended", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SettlementDefended { get; internal set; }

        [JsonProperty("Settlement_Conquered", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SettlementConquered { get; internal set; }

        [JsonProperty("OnFoot_Skimmers_Killed", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long OnFootSkimmersKilled { get; internal set; }

        [JsonProperty("OnFoot_Scavs_Killed", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long OnFootScavsKilled { get; internal set; }
    }
}