using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class Route
    {
        [JsonProperty]
        public string StarSystem { get; internal set; }

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public double[] StarPos { get; internal set; }

        [JsonProperty]
        public string StarClass { get; internal set; }
    }
}