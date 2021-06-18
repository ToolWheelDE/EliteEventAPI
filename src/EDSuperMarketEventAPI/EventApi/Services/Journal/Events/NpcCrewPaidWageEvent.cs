using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class NpcCrewPaidWageEvent : EventModelBase
    {
        [JsonProperty]
        public string NpcCrewName { get; internal set; }

        [JsonProperty]
        public long NpcCrewId { get; internal set; }

        [JsonProperty]
        public long Amount { get; internal set; }
    }
}
