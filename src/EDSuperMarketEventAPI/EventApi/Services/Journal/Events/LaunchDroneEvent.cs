using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class LaunchDroneEvent : EventModelBase
    {
        [JsonProperty]
        public string Type { get; internal set; }
    }
}
