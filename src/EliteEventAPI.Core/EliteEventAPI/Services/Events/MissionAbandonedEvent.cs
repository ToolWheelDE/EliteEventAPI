using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class MissionAbandonedEvent : EventModelBase
    {
        public override string Eventname => "MaterialTrade";

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long MissionId { get; internal set; }
    }
}