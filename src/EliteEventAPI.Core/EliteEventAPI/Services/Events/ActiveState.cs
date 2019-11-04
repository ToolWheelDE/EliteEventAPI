using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class ActiveState
    {
        [JsonProperty]
        public string State { get; internal set; }
    }
}