using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class PowerplayVoucherEvent : EventModelBase
    {
        protected internal override string Eventname => "PowerplayVoucher";

        [JsonProperty]
        public string Power { get; internal set; }

        [JsonProperty]
        public List<string> Systems { get; internal set; }
    }
}
