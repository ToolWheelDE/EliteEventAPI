using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class EngineerApplyEvent : EventModelBase
    {
        [JsonProperty]
        public string Engineer { get; internal set; }

        [JsonProperty]
        public string Blueprint { get; internal set; }

        [JsonProperty]
        public long Level { get; internal set; }

        [JsonProperty]
        public string Override { get; internal set; }
    }
}
