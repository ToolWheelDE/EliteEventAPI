using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class ShieldStateEvent : EventModelBase
    {
        protected internal override string Eventname => "ShieldState";

        [JsonProperty("ShieldsUp")]
        public bool ShieldsUp { get; internal set; }
    }
}
