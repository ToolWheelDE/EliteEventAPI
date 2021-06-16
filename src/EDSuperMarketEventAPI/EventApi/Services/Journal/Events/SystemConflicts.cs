using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
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