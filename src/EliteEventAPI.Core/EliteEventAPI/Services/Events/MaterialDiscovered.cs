using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class MaterialDiscoveredEvent : EventModelBase
    {
        protected internal override string Eventname => "MaterialDiscovered";

        [JsonProperty]
        public string Category { get; internal set; }

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; internal set; }

        [JsonProperty]
        public long DiscoveryNumber { get; internal set; }
    }
}