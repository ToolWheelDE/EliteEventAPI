using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class PayLegacyFinesEvent : EventModelBase
    {
        [JsonProperty]
        public long Amount { get; internal set; }

        [JsonProperty]
        public double BrokerPercentage { get; internal set; }
    }
}
