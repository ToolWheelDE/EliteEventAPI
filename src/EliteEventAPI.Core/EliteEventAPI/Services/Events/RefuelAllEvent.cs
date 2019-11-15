using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class RefuelAllEvent : EventModelBase
    {
        protected internal override string Eventname => "RefuelAll";

        [JsonProperty]
        public int Cost { get; internal set; }

        [JsonProperty]
        public double Amount { get; internal set; }
    }
}
