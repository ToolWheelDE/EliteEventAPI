using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class WingJoinEvent : EventModelBase
    {
        [JsonProperty]
        public string[] Others { get; internal set; }
    }
}
