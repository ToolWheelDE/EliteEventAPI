using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class Paid
    {
        [JsonProperty("")]
        public string Material { get; internal set; }

        [JsonProperty("Material_Localised")]
        public string MaterialLocalised { get; internal set; }

        [JsonProperty("")]
        public string Category { get; internal set; }

        [JsonProperty("Category_Localised")]
        public string CategoryLocalised { get; internal set; }

        [JsonProperty("")]
        public long Quantity { get; internal set; }
    }
}