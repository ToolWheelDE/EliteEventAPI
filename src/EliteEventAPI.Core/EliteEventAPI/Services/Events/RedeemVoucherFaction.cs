using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class RedeemVoucherFaction
    {
        [JsonProperty]
        public string Faction { get; internal set; }

        [JsonProperty]
        public long Amount { get; internal set; }
    }
}