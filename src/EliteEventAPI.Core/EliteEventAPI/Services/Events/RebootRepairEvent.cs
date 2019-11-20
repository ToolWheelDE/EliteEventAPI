using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class RebootRepairEvent : EventModelBase
    {
        protected internal override string Eventname => "RebootRepair";

        [JsonProperty]
        public string[] Modules { get; internal set; }
    }
}
