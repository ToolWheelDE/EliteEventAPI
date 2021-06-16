using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class MaterialDiscardedEvent : EventModelBase
    {
        [JsonProperty]
        public string Category { get; internal set; }

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }
    }
}