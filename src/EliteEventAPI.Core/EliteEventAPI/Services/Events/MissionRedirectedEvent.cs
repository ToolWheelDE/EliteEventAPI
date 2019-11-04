using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class MissionRedirectedEvent : EventModelBase
    {
        public override string Eventname => "MissionRedirected";

        [JsonProperty]
        public long MissionId { get; internal set; }

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public string NewDestinationStation { get; internal set; }

        [JsonProperty]
        public string NewDestinationSystem { get; internal set; }

        [JsonProperty]
        public string OldDestinationStation { get; internal set; }

        [JsonProperty]
        public string OldDestinationSystem { get; internal set; }
    }
}