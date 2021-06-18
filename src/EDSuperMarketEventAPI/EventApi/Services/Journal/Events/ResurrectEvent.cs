using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class ResurrectEvent : EventModelBase
    {
        [JsonProperty]
        public string Option { get; internal set; }

        [JsonProperty]
        public long Cost { get; internal set; }

        [JsonProperty]
        public bool Bankrupt { get; internal set; }
    }
}
