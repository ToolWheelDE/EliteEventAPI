using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class PayLegacyFinesEvent : EventModelBase
    {
        protected internal override string Eventname => "PayLegacyFines";

        [JsonProperty]
        public long Amount { get; internal set; }

        [JsonProperty]
        public double BrokerPercentage { get; internal set; }
    }
}
