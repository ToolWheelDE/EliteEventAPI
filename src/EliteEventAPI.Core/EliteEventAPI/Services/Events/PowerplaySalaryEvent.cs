using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class PowerplaySalaryEvent : EventModelBase
    {
        protected internal override string Eventname => "PowerplaySalary";

        [JsonProperty]
        public string Power { get; internal set; }

        [JsonProperty]
        public long Amount { get; internal set; }
    }
}
