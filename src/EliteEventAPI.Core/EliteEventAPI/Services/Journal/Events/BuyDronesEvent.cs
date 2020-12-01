using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class BuyDronesEvent : EventModelBase
    {
        [JsonProperty]
        public string Type { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }

        [JsonProperty]
        public long BuyPrice { get; internal set; }

        [JsonProperty]
        public long TotalCost { get; internal set; }
    }
}
