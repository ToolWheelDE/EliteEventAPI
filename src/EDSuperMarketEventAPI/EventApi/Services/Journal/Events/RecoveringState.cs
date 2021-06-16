using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class RecoveringState
    {
        [JsonProperty]
        public string  State  {get; internal set;}

        [JsonProperty]
        public double? Trend { get; internal set; }
    }
}