using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class VehicleSwitchEvent : EventModelBase
    {
        [JsonProperty]
        public string To { get; internal set; }
    }
}
