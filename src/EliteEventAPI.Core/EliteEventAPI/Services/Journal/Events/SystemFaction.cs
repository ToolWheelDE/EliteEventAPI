using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class SystemFaction
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public string FactionState { get; internal set; }
    }
}