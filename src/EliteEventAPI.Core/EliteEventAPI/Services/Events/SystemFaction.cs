using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public partial class SystemFaction
    {
        [JsonProperty]
        public string Name { get; internal set; }
    }
}