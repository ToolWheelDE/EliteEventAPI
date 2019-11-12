using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class MaterialCollectedEvent : EventModelBase
    {
        protected internal override string Eventname => "MaterialCollected";

        [JsonProperty]
        public string Category { get; internal set; }

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }
    }
}