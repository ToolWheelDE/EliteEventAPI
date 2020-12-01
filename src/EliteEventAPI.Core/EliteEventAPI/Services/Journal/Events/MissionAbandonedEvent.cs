using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class MissionAbandonedEvent : EventModelBase
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long MissionId { get; internal set; }
    }
}