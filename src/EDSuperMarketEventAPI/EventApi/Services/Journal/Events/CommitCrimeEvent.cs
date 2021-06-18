using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class CommitCrimeEvent : EventModelBase
    {
        [JsonProperty]
        public string CrimeType { get; internal set; }

        [JsonProperty]
        public string Faction { get; internal set; }

        [JsonProperty]
        public string Victim { get; internal set; }

        [JsonProperty("Victim_Localised")]
        public string VictimLocalised { get; internal set; }

        [JsonProperty]
        public long Bounty { get; internal set; }

        [JsonProperty]
        public int Fine { get; internal set; }
    }
}
