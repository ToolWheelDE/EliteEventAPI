using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class DatalinkVoucherEvent : EventModelBase
    {
        [JsonProperty]
        public long Reward { get; internal set; }

        [JsonProperty]
        public string VictimFaction { get; internal set; }

        [JsonProperty]
        public string PayeeFaction { get; internal set; }
    }
}
