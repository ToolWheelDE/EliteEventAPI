using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class ProspectedMaterial
    {
        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty("Name_Localised", NullValueHandling = NullValueHandling.Ignore)]
        public string NameLocalised { get; set; }

        [JsonProperty]
        public double Proportion { get; set; }
    }
}