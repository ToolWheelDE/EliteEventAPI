using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{

    public sealed class IngState
    {
        [JsonProperty]
        public string State { get; internal set; }

        [JsonProperty]
        public long Trend { get; internal set; }
    }
}