using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class ModuleSellRemoteEvent : EventModelBase
    {
        [JsonProperty]
        public long StorageSlot { get; internal set; }

        [JsonProperty]
        public string SellItem { get; internal set; }

        [JsonProperty("SellItem_Localised")]
        public string SellItemLocalised { get; internal set; }

        [JsonProperty]
        public long ServerId { get; internal set; }

        [JsonProperty]
        public long SellPrice { get; internal set; }

        [JsonProperty]
        public string Ship { get; internal set; }

        [JsonProperty]
        public long ShipId { get; internal set; }
    }
}
