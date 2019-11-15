using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class RepairEvent : EventModelBase
    {
        protected internal override string Eventname => "Repair";

        [JsonProperty]
        public string Item { get; internal set; }

        [JsonProperty]
        public int Cost { get; internal set; }
    }
}
