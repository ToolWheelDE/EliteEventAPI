using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class BuyDronesEvent : EventModelBase
    {
        protected internal override string Eventname => "BuyDrones";

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
