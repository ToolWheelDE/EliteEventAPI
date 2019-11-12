using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class MissionAbandonedEvent : EventModelBase
    {
        protected internal override string Eventname => "MissionAbandoned";

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long MissionId { get; internal set; }
    }
}