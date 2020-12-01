using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class ShipyardSwapEvent : EventModelBase
    {
        [JsonProperty]
        public string ShipType { get; internal set; }

        [JsonProperty("ShipType_Localised")]
        public string ShipTypeLocalised { get; internal set; }

        [JsonProperty]
        public long ShipId { get; internal set; }

        [JsonProperty]
        public string StoreOldShip { get; internal set; }

        [JsonProperty]
        public long StoreShipId { get; internal set; }

        [JsonProperty]
        public long MarketId { get; internal set; }
    }
}
