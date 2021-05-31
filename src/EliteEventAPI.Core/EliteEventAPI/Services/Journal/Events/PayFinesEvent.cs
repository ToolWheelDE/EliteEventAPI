using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class PayFinesEvent : EventModelBase
    {
        [JsonProperty]
        public long Amount { get; internal set; }

        [JsonProperty]
        public bool AllFines { get; internal set; }

        [JsonProperty]
        public string Faction { get; internal set; }

        [JsonProperty]
        public long ShipId { get; internal set; }

        [JsonProperty]
        public double BrokerPercentage { get; internal set; }
    }
}
