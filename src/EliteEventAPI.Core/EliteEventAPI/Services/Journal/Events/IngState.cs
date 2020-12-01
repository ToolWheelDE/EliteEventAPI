using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{

    public sealed class IngState
    {
        [JsonProperty]
        public string State { get; internal set; }

        [JsonProperty]
        public long Trend { get; internal set; }
    }
}