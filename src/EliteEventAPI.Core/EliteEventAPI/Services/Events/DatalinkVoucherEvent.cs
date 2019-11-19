using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class DatalinkVoucherEvent : EventModelBase
    {
        protected internal override string Eventname => "DatalinkVoucher";

        [JsonProperty]
        public long Reward { get; internal set; }

        [JsonProperty]
        public string VictimFaction { get; internal set; }

        [JsonProperty]
        public string PayeeFaction { get; internal set; }
    }
}
