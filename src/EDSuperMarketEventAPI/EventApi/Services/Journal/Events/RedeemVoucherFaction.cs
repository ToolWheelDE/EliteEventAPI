using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class RedeemVoucherFaction
    {
        [JsonProperty]
        public string Faction { get; internal set; }

        [JsonProperty]
        public long Amount { get; internal set; }
    }
}