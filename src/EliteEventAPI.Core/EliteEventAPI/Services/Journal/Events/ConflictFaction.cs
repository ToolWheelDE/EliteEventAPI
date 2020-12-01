using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public class ConflictFaction
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public string Stake { get; internal set; }

        [JsonProperty]
        public int WonDays { get; internal set; }
    }
}