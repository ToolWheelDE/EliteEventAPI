using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class ModuleSlot
    {
        [JsonProperty]
        public string Slot { get; internal set; }

        [JsonProperty]
        public string Item { get; internal set; }

        [JsonProperty]
        public double Power { get; internal set; }

        [JsonProperty]
        public double Priority { get; internal set; }
    }
}