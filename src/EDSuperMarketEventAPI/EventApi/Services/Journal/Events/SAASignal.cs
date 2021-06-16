using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class SAASignal
    {
        [JsonProperty]
        public string Type { get; internal set; }

        [JsonProperty]
        public string Type_Localised { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }
    }
}