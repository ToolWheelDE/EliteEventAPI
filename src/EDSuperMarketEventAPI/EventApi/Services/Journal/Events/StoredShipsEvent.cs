using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class StoredShipsEvent : EventModelBase
    {
        [JsonProperty]
        public string StationName { get; internal set; }

        [JsonProperty]
        public long MarketId { get; internal set; }

        [JsonProperty]
        public string StarSystem { get; internal set; }

        [JsonProperty]
        public object[] ShipsHere { get; internal set; }

        [JsonProperty]
        public ShipsRemote[] ShipsRemote { get; internal set; }
    }
}
