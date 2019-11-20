using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class MissionCompletedEvent : EventModelBase
    {
        [JsonProperty]
        public string Faction { get; internal set; }

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long MissionId { get; internal set; }

        [JsonProperty]
        public string TargetType { get; internal set; }

        [JsonProperty("TargetType_Localised")]
        public string TargetTypeLocalised { get; internal set; }

        [JsonProperty]
        public string TargetFaction { get; internal set; }

        [JsonProperty]
        public string NewDestinationSystem { get; internal set; }

        [JsonProperty]
        public string DestinationSystem { get; internal set; }

        [JsonProperty]
        public string NewDestinationStation { get; internal set; }

        [JsonProperty]
        public string DestinationStation { get; internal set; }

        [JsonProperty]
        public string Target { get; internal set; }

        [JsonProperty]
        public long Reward { get; internal set; }

        [JsonProperty]
        public MissionMaterialsReward[] MaterialsReward { get; internal set; }

        [JsonProperty]
        public MissionFactionEffect[] FactionEffects { get; internal set; }
    }








}