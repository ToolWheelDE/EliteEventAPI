using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class StoredModule
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; internal set; }

        [JsonProperty]
        public int StorageSlot { get; internal set; }

        [JsonProperty]
        public string StarSystem { get; internal set; }

        [JsonProperty]
        public long MarketID { get; internal set; }

        [JsonProperty]
        public int TransferCost { get; internal set; }

        [JsonProperty]
        public int TransferTime { get; internal set; }

        [JsonProperty]
        public int BuyPrice { get; internal set; }

        [JsonProperty]
        public bool Hot { get; internal set; }
    }
}