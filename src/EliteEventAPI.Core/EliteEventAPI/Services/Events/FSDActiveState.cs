using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class FSDActiveState
    {
        [JsonProperty]
        public string State { get; internal set; }
    }
}