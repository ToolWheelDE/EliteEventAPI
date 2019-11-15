using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class MissionsEvent : EventModelBase
    {
        protected internal override string Eventname => "Missions";

        [JsonProperty]
        public MissionDetails[] Active { get; internal set; }

        [JsonProperty]
        public MissionDetails[] Failed { get; internal set; }

        [JsonProperty]
        public MissionDetails[] Complete { get; internal set; }
    }
}