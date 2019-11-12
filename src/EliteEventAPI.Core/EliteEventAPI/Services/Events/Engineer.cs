using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class Engineer
    {
        [JsonProperty("Engineer")]
        public string EngineerName { get; internal set; }

        [JsonProperty]
        public long EngineerID { get; internal set; }

        [JsonProperty]
        public string Progress { get; internal set; }
    }
}