using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class PowerplayJoinEvent : EventModelBase
    {
        protected internal override string Eventname => "PowerplayJoin";

        [JsonProperty]
        public string Power { get; internal set; }
    }
}
