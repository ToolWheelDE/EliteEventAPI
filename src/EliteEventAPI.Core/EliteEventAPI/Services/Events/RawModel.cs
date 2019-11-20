using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class RawModel
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }
    }
}