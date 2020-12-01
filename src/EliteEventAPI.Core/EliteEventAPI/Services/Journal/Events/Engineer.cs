using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class Engineer
    {
        [JsonProperty("Engineer")]
        public string EngineerName { get; internal set; }

        [JsonProperty]
        public long EngineerID { get; internal set; }

        [JsonProperty]
        public string Progress { get; internal set; }

        [JsonProperty]
        public int RankProgress { get; internal set; }

        [JsonProperty]
        public int Rank { get; internal set; }
    }
}