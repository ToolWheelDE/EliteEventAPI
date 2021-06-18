using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class PVPKillEvent : EventModelBase
    {
        [JsonProperty]
        public string Victim { get; internal set; }

        [JsonProperty]
        public long CombatRank { get; internal set; }
    }
}
