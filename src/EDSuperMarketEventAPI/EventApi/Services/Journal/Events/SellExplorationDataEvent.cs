using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class SellExplorationDataEvent : EventModelBase
    {
        [JsonProperty]
        public string[] Systems { get; internal set; }

        [JsonProperty]
        public string[] Discovered { get; internal set; }

        [JsonProperty]
        public long BaseValue { get; internal set; }

        [JsonProperty]
        public long Bonus { get; internal set; }

        [JsonProperty]
        public long TotalEarnings { get; internal set; }
    }
}
