using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class FSSSignalDiscoveredEvent : EventModelBase
    {
        protected internal override string Eventname => "FSSSignalDiscovered";

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public string SignalName { get; internal set; }

        [JsonProperty("SignalName_Localised")]
        public string SignalNameLocalised { get; internal set; }

        [JsonProperty]
        public string UssType { get; internal set; }

        [JsonProperty("USSType_Localised")]
        public string UssTypeLocalised { get; internal set; }

        [JsonProperty]
        public string SpawningState { get; internal set; }

        [JsonProperty("SpawningState_Localised")]
        public string SpawningStateLocalised { get; internal set; }

        [JsonProperty]
        public string SpawningFaction { get; internal set; }

        [JsonProperty]
        public long ThreatLevel { get; internal set; }

        [JsonProperty]
        public double TimeRemaining { get; internal set; }

        [JsonProperty]
        public bool IsStation { get; internal set; }
    }
}