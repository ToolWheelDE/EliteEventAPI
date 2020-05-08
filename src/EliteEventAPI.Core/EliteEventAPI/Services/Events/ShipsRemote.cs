using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class ShipsRemote
    {
        [JsonProperty]
        public long ShipId { get; internal set; }

        [JsonProperty]
        public string ShipType { get; internal set; }

        [JsonProperty]
        public bool InTransit { get; internal set; }

        [JsonProperty]
        public string StarSystem { get; internal set; }

        [JsonProperty]
        public long ShipMarketId { get; internal set; }

        [JsonProperty]
        public long TransferPrice { get; internal set; }

        [JsonProperty]
        public long TransferTime { get; internal set; }

        [JsonProperty]
        public long Value { get; internal set; }

        [JsonProperty]
        public bool Hot { get; internal set; }

        [JsonProperty("ShipType_Localised", NullValueHandling = NullValueHandling.Ignore)]
        public string ShipTypeLocalised { get; internal set; }

        [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; internal set; }
    }
}