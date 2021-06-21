using Newtonsoft.Json;
using System.Collections.Generic;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class StatisticsEvent : EventModelBase
    {
        [JsonProperty("Bank_Account")]
        public BankAccountStatistic BankAccount { get; internal set; }

        [JsonProperty("Combat")]
        public CombatStatistic Combat { get; internal set; }

        [JsonProperty("Crime")]
        public CrimeStatistic Crime { get; internal set; }

        [JsonProperty("Smuggling")]
        public SmugglingStatistic Smuggling { get; internal set; }

        [JsonProperty("Trading")]
        public TradingStatistic Trading { get; internal set; }

        [JsonProperty("Mining")]
        public MiningStatistic Mining { get; internal set; }

        [JsonProperty("Exploration")]
        public ExplorationStatistic Exploration { get; internal set; }

        [JsonProperty("Passengers")]
        public PassengersStatistic Passengers { get; internal set; }

        [JsonProperty("Search_And_Rescue")]
        public SearchAndRescueStatistic SearchAndRescue { get; internal set; }

        [Obsolete("Not found in newer journal files.")]
        [JsonProperty("TG_ENCOUNTERS", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public TgEncountersStatistic TgEncounters { get; internal set; }

        [JsonProperty("Crafting")]
        public CraftingStatistic Crafting { get; internal set; }

        [JsonProperty("Crew")]
        public CrewStatistic Crew { get; internal set; }

        [JsonProperty("Multicrew")]
        public MulticrewStatistic Multicrew { get; internal set; }

        [JsonProperty("Material_Trader_Stats")]
        public MaterialTraderStatistic MaterialTraderStats { get; internal set; }

        [Obsolete("Not found in newer journal files.")]
        [JsonProperty("CQC", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Dictionary<string, double> Cqc { get; internal set; }

        [JsonProperty("Exobiology")]
        public ExobiologyStatistic Exobiology { get; internal set; }
    }
}
