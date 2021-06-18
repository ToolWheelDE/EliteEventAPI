using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class LoadOutFuel
    {
        [JsonProperty]
        public double Main { get; internal set; }

        [JsonProperty]
        public double Reserve { get; internal set; }
    }
}
