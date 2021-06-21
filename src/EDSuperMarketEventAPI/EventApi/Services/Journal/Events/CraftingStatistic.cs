using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class CraftingStatistic
    {
        [JsonProperty("Count_Of_Used_Engineers", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long CountOfUsedEngineers { get; internal set; }

        [JsonProperty("Recipes_Generated", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long RecipesGenerated { get; internal set; }

        [JsonProperty("Recipes_Generated_Rank_1", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long RecipesGeneratedRank1 { get; internal set; }

        [JsonProperty("Recipes_Generated_Rank_2", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long RecipesGeneratedRank2 { get; internal set; }

        [JsonProperty("Recipes_Generated_Rank_3", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long RecipesGeneratedRank3 { get; internal set; }

        [JsonProperty("Recipes_Generated_Rank_4", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long RecipesGeneratedRank4 { get; internal set; }

        [JsonProperty("Recipes_Generated_Rank_5", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long RecipesGeneratedRank5 { get; internal set; }

        [JsonProperty("Suit_Mods_Applied", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SuitModsApplied { get; internal set; }

        [JsonProperty("Weapon_Mods_Applied", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long WeaponModsApplied { get; internal set; }

        [JsonProperty("Suits_Upgraded", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SuitsUpgraded { get; internal set; }

        [JsonProperty("Weapons_Upgraded", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long WeaponsUpgraded { get; internal set; }

        [JsonProperty("Suits_Upgraded_Full", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SuitsUpgradedFull { get; internal set; }

        [JsonProperty("Weapons_Upgraded_Full", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long WeaponsUpgradedFull { get; internal set; }

        [JsonProperty("Suit_Mods_Applied_Full", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SuitModsAppliedFull { get; internal set; }

        [JsonProperty("Weapon_Mods_Applied_Full", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long WeaponModsAppliedFull { get; internal set; }
    }
}