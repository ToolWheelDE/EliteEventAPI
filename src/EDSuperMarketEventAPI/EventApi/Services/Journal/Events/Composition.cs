using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class Composition
    {
        [JsonProperty]
        public double Ice { get; internal set; }

        [JsonProperty]
        public double Rock { get; internal set; }

        [JsonProperty]
        public double Metal { get; internal set; }
    }
}
