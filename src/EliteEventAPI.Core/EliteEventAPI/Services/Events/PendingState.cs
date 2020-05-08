using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public class PendingState
    {
        [JsonProperty]
        public string State { get; internal set; }

        [JsonProperty]
        public double? Trend { get; internal set; }
    }
}