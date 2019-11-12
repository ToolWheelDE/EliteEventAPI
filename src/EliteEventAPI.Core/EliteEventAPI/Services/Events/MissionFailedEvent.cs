using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class MissionFailedEvent : EventModelBase
    {
        protected internal override string Eventname => "MissionFailed";

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long MissionId { get; internal set; }
    }
}