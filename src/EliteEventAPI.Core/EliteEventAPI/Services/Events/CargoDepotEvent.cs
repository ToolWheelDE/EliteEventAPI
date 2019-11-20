using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class CargoDepotEvent : EventModelBase
    {
        [JsonProperty]
        public long MissionId { get; internal set; }

        [JsonProperty]
        public string UpdateType { get; internal set; }

        [JsonProperty]
        public string CargoType { get; internal set; }

        [JsonProperty("CargoType_Localised")]
        public string CargoTypeLocalised { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }

        [JsonProperty]
        public long StartMarketId { get; internal set; }

        [JsonProperty]
        public long EndMarketId { get; internal set; }

        [JsonProperty]
        public long ItemsCollected { get; internal set; }

        [JsonProperty]
        public long ItemsDelivered { get; internal set; }

        [JsonProperty]
        public long TotalItemsToDeliver { get; internal set; }

        [JsonProperty]
        public double Progress { get; internal set; }
    }
}
