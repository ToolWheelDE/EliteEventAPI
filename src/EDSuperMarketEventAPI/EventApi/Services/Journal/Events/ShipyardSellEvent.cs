using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class ShipyardSellEvent : EventModelBase
    {
        [JsonProperty]
        public string ShipType { get; internal set; }

        [JsonProperty("ShipType_Localised")]
        public string ShipTypeLocalised { get; internal set; }

        [JsonProperty]
        public long SellShipId { get; internal set; }

        [JsonProperty]
        public long ShipPrice { get; internal set; }

        [JsonProperty]
        public long ShipMarketId { get; internal set; }

        [JsonProperty]
        public long MarketId { get; internal set; }

        [JsonProperty]
        public string System { get; internal set; }
    }
}
