using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class RepairAllEvent : EventModelBase
    {
        protected internal override string Eventname => "RepairAll";

        [JsonProperty]
        public int Cost { get; internal set; }
    }
}
