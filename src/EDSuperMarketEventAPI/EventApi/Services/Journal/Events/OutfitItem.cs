using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class OutfitItem
    {
        [JsonProperty("id")]
        public long ID { get; internal set; }

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public int BuyPrice { get; internal set; }
    }
}