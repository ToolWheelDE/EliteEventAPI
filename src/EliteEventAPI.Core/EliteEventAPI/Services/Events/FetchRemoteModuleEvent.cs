using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class FetchRemoteModuleEvent : EventModelBase
    {
        protected internal override string Eventname => "FetchRemoteModule";

        [JsonProperty]
        public long StorageSlot { get; internal set; }

        [JsonProperty]
        public string StoredItem { get; internal set; }

        [JsonProperty("StoredItem_Localised")]
        public string StoredItemLocalised { get; internal set; }

        [JsonProperty]
        public long ServerId { get; internal set; }

        [JsonProperty]
        public long TransferCost { get; internal set; }

        [JsonProperty]
        public long TransferTime { get; internal set; }

        [JsonProperty]
        public string Ship { get; internal set; }

        [JsonProperty]
        public long ShipId { get; internal set; }
    }
}
