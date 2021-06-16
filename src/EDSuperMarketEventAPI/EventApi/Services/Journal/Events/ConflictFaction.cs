using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
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