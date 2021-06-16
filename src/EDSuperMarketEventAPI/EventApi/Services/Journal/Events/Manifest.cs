using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class Manifest
    {
        [JsonProperty]
        public long MissionId { get; internal set; }

        [JsonProperty]
        public string Type { get; internal set; }

        [JsonProperty]
        public bool Vip { get; internal set; }

        [JsonProperty]
        public bool Wanted { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }
    }
}