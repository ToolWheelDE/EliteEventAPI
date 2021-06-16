using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class PendingState
    {
        [JsonProperty]
        public string State { get; internal set; }

        [JsonProperty]
        public double? Trend { get; internal set; }
    }
}