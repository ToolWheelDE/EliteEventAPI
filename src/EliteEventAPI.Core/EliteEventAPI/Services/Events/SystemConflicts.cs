using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public class SystemConflicts
    {
        [JsonProperty]
        public string WarType   {get;internal set;}

        [JsonProperty]
        public string Status    {get;internal set;}

        [JsonProperty]
        public SystemConflictFaction Faction1  {get;internal set;}

        [JsonProperty]
        public SystemConflictFaction Faction2  {get;internal set;}
    }
}