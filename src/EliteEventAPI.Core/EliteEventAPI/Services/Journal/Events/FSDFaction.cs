using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class FSDFaction
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

        [JsonProperty("Happiness_Localised", NullValueHandling = NullValueHandling.Ignore)]
        public string HappinessLocalised { get; internal set; }

        [JsonProperty]
        public double MyReputation { get; internal set; }

        [JsonProperty("RecoveringStates", NullValueHandling = NullValueHandling.Ignore)]
        public IngState[] RecoveringStates { get; internal set; }

        [JsonProperty("PendingStates", NullValueHandling = NullValueHandling.Ignore)]
        public IngState[] PendingStates { get; internal set; }

        [JsonProperty("ActiveStates", NullValueHandling = NullValueHandling.Ignore)]
        public FSDActiveState[] ActiveStates { get; internal set; }
    }
}