using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class MissionFactionEffect
    {
        [JsonProperty]
        public string Faction { get; internal set; }

        [JsonProperty]
        public MissionEffect[] Effects { get; internal set; }

        [JsonProperty]
        public MissionInfluence[] Influence { get; internal set; }

        [JsonProperty]
        public string ReputationTrend { get; internal set; }

        [JsonProperty]
        public string Reputation { get; internal set; }
    }
}