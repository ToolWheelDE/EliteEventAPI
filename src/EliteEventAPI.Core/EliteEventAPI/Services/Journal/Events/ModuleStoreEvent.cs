using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class ModuleStoreEvent : EventModelBase
    {
        [JsonProperty]
        public long MarketId { get; internal set; }

        [JsonProperty]
        public string Slot { get; internal set; }

        [JsonProperty]
        public string StoredItem { get; internal set; }

        [JsonProperty("StoredItem_Localised")]
        public string StoredItemLocalised { get; internal set; }

        [JsonProperty]
        public string Ship { get; internal set; }

        [JsonProperty]
        public long ShipId { get; internal set; }

        [JsonProperty]
        public bool Hot { get; internal set; }

        [JsonProperty]
        public string EngineerModifications { get; internal set; }

        [JsonProperty]
        public long Level { get; internal set; }

        [JsonProperty]
        public double Quality { get; internal set; }
    }
}
