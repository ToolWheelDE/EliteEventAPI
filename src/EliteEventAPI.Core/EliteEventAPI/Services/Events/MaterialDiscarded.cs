using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class MaterialDiscardedInfo : EventModelBase
    {
        public override string Eventname => "MaterialDiscarded";

        [JsonProperty]
        public string Category { get; internal set; }

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }
    }
}