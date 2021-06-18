using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{

    public sealed class ShipLockerEvent : EventModelBase
    {
        [JsonProperty]
        public ShipLockerItem[] Items { get; internal set; }

        [JsonProperty]
        public ShipLockerItem[] Components { get; internal set; }

        [JsonProperty]
        public ShipLockerItem[] Consumables { get; internal set; }

        [JsonProperty]
        public ShipLockerItem[] Data { get; internal set; }
    }
}
