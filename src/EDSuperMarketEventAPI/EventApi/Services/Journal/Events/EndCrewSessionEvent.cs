using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class EndCrewSessionEvent : EventModelBase
    {
        [JsonProperty]
        public bool OnCrime { get; internal set; }
    }
}
