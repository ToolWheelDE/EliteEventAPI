using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class DatalinkVoucherEvent : EventModelBase
    {
        [JsonProperty]
        public long Reward { get; internal set; }

        [JsonProperty]
        public string VictimFaction { get; internal set; }

        [JsonProperty]
        public string PayeeFaction { get; internal set; }
    }
}
