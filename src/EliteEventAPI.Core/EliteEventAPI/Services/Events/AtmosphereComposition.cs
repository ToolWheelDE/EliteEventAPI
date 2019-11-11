using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class AtmosphereComposition
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public double Percent { get; internal set; }
    }
}