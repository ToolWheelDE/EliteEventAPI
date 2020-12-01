using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class RepairAllEvent : EventModelBase
    {
        [JsonProperty]
        public int Cost { get; internal set; }
    }
}
