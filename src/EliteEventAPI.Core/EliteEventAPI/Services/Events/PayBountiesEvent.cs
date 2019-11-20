using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class PayBountiesEvent : EventModelBase
    {
        [JsonProperty]
        public long Amount { get; internal set; }

        [JsonProperty]
        public string Faction { get; internal set; }

        [JsonProperty("Faction_Localised")]
        public string FactionLocalised { get; internal set; }

        [JsonProperty]
        public long ShipId { get; internal set; }

        [JsonProperty]
        public double BrokerPercentage { get; internal set; }
    }
}
