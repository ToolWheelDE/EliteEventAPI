using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class Conflict
    {
        [JsonProperty]
        public string WarType { get; internal set; }

        [JsonProperty]
        public string Status { get; internal set; }

        [JsonProperty]
        public ConflictFaction Faction1 { get; internal set; }

        [JsonProperty]
        public ConflictFaction Faction2 { get; internal set; }
    }
}
