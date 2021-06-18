using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class Ring
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public string RingClass { get; internal set; }

        [JsonProperty]
        public double MassMt { get; internal set; }

        [JsonProperty]
        public double InnerRad { get; internal set; }

        [JsonProperty]
        public double OuterRad { get; internal set; }
    }
}
