using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class DiscovererData
    {
        [JsonProperty]
        public string SystemName { get; internal set; }

        [JsonProperty]
        public int NumBodies { get; internal set; }
    }
}