using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class MissionDetails
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