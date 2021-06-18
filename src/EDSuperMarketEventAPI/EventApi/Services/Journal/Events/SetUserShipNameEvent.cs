using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class SetUserShipNameEvent : EventModelBase
    {
        [JsonProperty]
        public string Ship { get; internal set; }

        [JsonProperty]
        public long ShipId { get; internal set; }

        [JsonProperty]
        public string UserShipName { get; internal set; }

        [JsonProperty]
        public string UserShipId { get; internal set; }
    }
}
