using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class RebootRepairEvent : EventModelBase
    {
        [JsonProperty]
        public string[] Modules { get; internal set; }
    }
}
