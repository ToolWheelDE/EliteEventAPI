using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class RawModel
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }
    }
}