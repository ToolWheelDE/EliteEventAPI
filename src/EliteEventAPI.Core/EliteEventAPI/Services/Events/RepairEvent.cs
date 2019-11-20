using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class RepairEvent : EventModelBase
    {
        [JsonProperty]
        public string Item { get; internal set; }

        [JsonProperty]
        public int Cost { get; internal set; }
    }
}
