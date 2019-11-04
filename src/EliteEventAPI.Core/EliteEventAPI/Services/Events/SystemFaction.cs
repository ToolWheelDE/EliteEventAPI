using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class SystemFaction
    {
        [JsonProperty]
        public string Name { get; internal set; }
    }
}