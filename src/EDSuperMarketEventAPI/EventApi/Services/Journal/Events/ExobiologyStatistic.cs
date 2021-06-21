using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class ExobiologyStatistic
    {
        [JsonProperty("Organic_Genus_Encountered", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long OrganicGenusEncountered { get; internal set; }

        [JsonProperty("Organic_Species_Encountered", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long OrganicSpeciesEncountered { get; internal set; }

        [JsonProperty("Organic_Variant_Encountered", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long OrganicVariantEncountered { get; internal set; }

        [JsonProperty("Organic_Data_Profits", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long OrganicDataProfits { get; internal set; }

        [JsonProperty("Organic_Data", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long Organi_Data { get; internal set; }

        [JsonProperty("First_Logged_Profits", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long FirstLoggedProfits { get; internal set; }

        [JsonProperty("First_Logged", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long FirstLogged { get; internal set; }

        [JsonProperty("Organic_Planets", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long OrganicPlanets { get; internal set; }

        [JsonProperty("Organic_Systems", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long OrganicSystems { get; internal set; }

        [JsonProperty("Organic_Genus", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long OrganicGenus { get; internal set; }

        [JsonProperty("Organic_Species", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long OrganicSpecies { get; internal set; }
    }
}