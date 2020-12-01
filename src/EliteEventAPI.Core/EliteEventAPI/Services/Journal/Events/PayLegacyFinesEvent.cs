using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class PayLegacyFinesEvent : EventModelBase
    {
        [JsonProperty]
        public long Amount { get; internal set; }

        [JsonProperty]
        public double BrokerPercentage { get; internal set; }
    }
}
