using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class ShieldStateEvent : EventModelBase
    {
        [JsonProperty("ShieldsUp")]
        public bool ShieldsUp { get; internal set; }
    }
}
