using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
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
        public string Commodity { get; internal set; }

        [JsonProperty("Commodity_Localised")]
        public string CommodityLocalised {get;internal set;}

        [JsonProperty]
        public int Count { get; internal set; }

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
        public Commodity[] CommodityReward { get; internal set; }

        [JsonProperty]
        public MissionMaterialsReward[] MaterialsReward { get; internal set; }

        [JsonProperty]
        public MissionFactionEffect[] FactionEffects { get; internal set; }
    }








}