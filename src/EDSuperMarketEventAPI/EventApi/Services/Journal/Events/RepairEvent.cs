using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class RepairEvent : EventModelBase
    {
        [JsonProperty]
        public string Item { get; internal set; }

        [JsonProperty]
        public int Cost { get; internal set; }
    }
}
