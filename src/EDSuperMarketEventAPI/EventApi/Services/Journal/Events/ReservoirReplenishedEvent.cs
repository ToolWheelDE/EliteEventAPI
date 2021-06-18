using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class ReservoirReplenishedEvent : EventModelBase
    {
        [JsonProperty]
        public double FuelMain { get; set; }

        [JsonProperty]
        public double FuelReservoir { get; set; }
    }
}
