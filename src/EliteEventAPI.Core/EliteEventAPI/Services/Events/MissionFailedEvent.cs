using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class MissionFailedEvent : EventModelBase
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long MissionId { get; internal set; }
    }
}