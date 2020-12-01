using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public class ItemsUnlocked
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; internal set; }
    }
}