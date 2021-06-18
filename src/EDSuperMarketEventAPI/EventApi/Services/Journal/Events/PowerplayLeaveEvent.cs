using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class PowerplayLeaveEvent : EventModelBase
    {
        [JsonProperty]
        public string Power { get; internal set; }
    }
}
