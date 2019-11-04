using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class MaterialTradeEvent : EventModelBase
    {
        public override string Eventname => "MaterialTrade";

        [JsonProperty("")]
        public long MarketId { get; internal set; }

        [JsonProperty("")]
        public string TraderType { get; internal set; }

        [JsonProperty("")]
        public Paid Paid { get; internal set; }

        [JsonProperty("")]
        public Paid Received { get; internal set; }
    }
}