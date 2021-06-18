using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class RedeemVoucherEvent : EventModelBase
    {
        [JsonProperty]
        public string Type { get; internal set; }

        [JsonProperty]
        public long Amount { get; internal set; }

        [JsonProperty]
        public RedeemVoucherFaction[] Factions { get; internal set; }
    }
}
