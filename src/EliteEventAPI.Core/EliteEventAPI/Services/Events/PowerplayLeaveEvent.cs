using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class PowerplayLeaveEvent : EventModelBase
    {
        protected internal override string Eventname => "PowerplayLeave";

        [JsonProperty]
        public string Power { get; internal set; }
    }
}
