using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public class ShipLockerItem
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; internal set; }

        [JsonProperty]
        public long OwnerId { get; internal set; }

        [JsonProperty]
        public int Count { get; internal set; }
    }
}