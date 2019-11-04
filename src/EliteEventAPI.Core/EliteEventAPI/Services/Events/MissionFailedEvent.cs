using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class MissionFailedEvent : EventModelBase
    {
        public override string Eventname => "MissionFailed";

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long MissionId { get; internal set; }
    }
}