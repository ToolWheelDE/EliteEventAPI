using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public partial class ActiveState
    {
        [JsonProperty]
        public string State { get; internal set; }
    }
}