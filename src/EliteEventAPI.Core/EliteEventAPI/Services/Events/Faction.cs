using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public partial class Faction
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public string FactionState { get; internal set; }

        [JsonProperty]
        public string Government { get; internal set; }

        [JsonProperty]
        public double Influence { get; internal set; }

        [JsonProperty]
        public string Allegiance { get; internal set; }

        [JsonProperty]
        public string Happiness { get; internal set; }

        [JsonProperty("Happiness_Localised")]
        public string HappinessLocalised { get; internal set; }

        [JsonProperty]
        public double MyReputation { get; internal set; }

        [JsonProperty("ActiveStates", NullValueHandling = NullValueHandling.Ignore)]
        public ActiveState[] ActiveStates { get; internal set; }
    }
}