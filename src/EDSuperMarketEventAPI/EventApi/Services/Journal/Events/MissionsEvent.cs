using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    /// <summary>
    /// Triggerd on startup
    /// </summary>
    public sealed class MissionsEvent : EventModelBase
    {
        [JsonProperty]
        public MissionDetails[] Active { get; internal set; }

        [JsonProperty]
        public MissionDetails[] Failed { get; internal set; }

        [JsonProperty]
        public MissionDetails[] Complete { get; internal set; }
    }
}