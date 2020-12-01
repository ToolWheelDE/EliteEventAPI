using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class ShipyardTransferEvent : EventModelBase
    {
        [JsonProperty]
        public string ShipType { get; internal set; }

        [JsonProperty("ShipType_Localised")]
        public string ShipTypeLocalised { get; internal set; }

        [JsonProperty]
        public long ShipId { get; internal set; }

        [JsonProperty]
        public string System { get; internal set; }

        [JsonProperty]
        public long ShipMarketId { get; internal set; }

        [JsonProperty]
        public double Distance { get; internal set; }

        [JsonProperty]
        public long TransferPrice { get; internal set; }

        [JsonProperty]
        public long TransferTime { get; internal set; }

        [JsonProperty]
        public long MarketId { get; internal set; }
    }
}
