using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class Inventory
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty("Name_Localised", NullValueHandling = NullValueHandling.Ignore)]
        public string NameLocalised { get; internal set; }

        [JsonProperty]
        public int Count { get; internal set; }

        [JsonProperty]
        public int Stolen { get; internal set; }
    }
}