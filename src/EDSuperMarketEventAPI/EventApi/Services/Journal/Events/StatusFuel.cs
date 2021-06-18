using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class StatusFuel
    {
        [JsonProperty]
        public double FuelMain { get; internal set; }

        [JsonProperty]
        public double FuelReservoir { get; internal set; }
    }
}
