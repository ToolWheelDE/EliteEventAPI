using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class EngineerContributionEvent : EventModelBase
    {
        [JsonProperty]
        public string Engineer { get; internal set; }

        [JsonProperty]
        public string Type { get; internal set; }

        [JsonProperty]
        public string Material { get; internal set; }

        [JsonProperty]
        public long Quantity { get; internal set; }

        [JsonProperty]
        public long TotalQuantity { get; internal set; }
    }
}
