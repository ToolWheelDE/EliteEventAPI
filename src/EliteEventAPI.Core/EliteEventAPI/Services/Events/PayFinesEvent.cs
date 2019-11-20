using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class PayFinesEvent : EventModelBase
    {
        protected internal override string Eventname => "PayFines";

        [JsonProperty]
        public long Amount { get; internal set; }

        [JsonProperty]
        public bool AllFines { get; internal set; }

        [JsonProperty]
        public string Faction { get; internal set; }

        [JsonProperty]
        public long ShipId { get; internal set; }
    }
}
