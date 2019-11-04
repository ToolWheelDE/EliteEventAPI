using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class MissionsEvent : EventModelBase
    {
        public override string Eventname => "Missions";

        [JsonProperty]
        public MissionActive[] Active { get; internal set; }

        [JsonProperty]
        public object[] Failed { get; internal set; }

        [JsonProperty]
        public object[] Complete { get; internal set; }
    }

   
}