using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class MissionActive
    {
        [JsonProperty]
        public long MissionId { get; internal set; }

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public bool PassengerMission { get; internal set; }

        [JsonProperty]
        public long Expires { get; internal set; }
    }
}