using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class SAAScanCompleteEvent : EventModelBase
    {
        [JsonProperty]
        public string BodyName { get; internal set; }

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public long BodyId { get; internal set; }

        [JsonProperty]
        public long ProbesUsed { get; internal set; }

        [JsonProperty]
        public long EfficiencyTarget { get; internal set; }
    }
}
