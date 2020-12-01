using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class ActiveState
    {
        [JsonProperty]
        public string State { get; internal set; }
    }
}