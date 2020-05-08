using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public class RecoveringState
    {
        [JsonProperty]
        public string  State  {get; internal set;}

        [JsonProperty]
        public double? Trend { get; internal set; }
    }
}