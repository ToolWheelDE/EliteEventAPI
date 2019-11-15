using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class MultiSellExplorationDataEvent : EventModelBase
    {
        protected internal override string Eventname => "MultiSellExplorationData";

        [JsonProperty]
        public DiscovererData[] Discovered { get; internal set; }

        [JsonProperty]
        public int BaseValue { get; internal set; }

        [JsonProperty]
        public int Bonus { get; internal set; }

        [JsonProperty]
        public int TotalEarnings { get; internal set; }
    }
}
