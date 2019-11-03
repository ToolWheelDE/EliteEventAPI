using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class Item
    {
        [JsonProperty]
        public string Slot { get; internal set; }

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; internal set; }

        [JsonProperty]
        public bool Hot { get; internal set; }

        [JsonProperty]
        public string EngineerModifications { get; internal set; }

        [JsonProperty]
        public long Level { get; internal set; }

        [JsonProperty]
        public double Quality { get; internal set; }
    }
}