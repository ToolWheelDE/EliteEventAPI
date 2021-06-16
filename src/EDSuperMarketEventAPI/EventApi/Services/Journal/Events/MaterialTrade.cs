using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class MaterialTradeEvent : EventModelBase
    {
        [JsonProperty]
        public long MarketId { get; internal set; }

        [JsonProperty]
        public string TraderType { get; internal set; }

        [JsonProperty]
        public Paid Paid { get; internal set; }

        [JsonProperty]
        public Paid Received { get; internal set; }
    }
}