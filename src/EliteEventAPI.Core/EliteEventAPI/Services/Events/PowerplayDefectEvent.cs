using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class PowerplayDefectEvent : EventModelBase
    {
        protected internal override string Eventname => "PowerplayDefect";

        [JsonProperty]
        public string FromPower { get; internal set; }

        [JsonProperty]
        public string ToPower { get; internal set; }
    }
}
