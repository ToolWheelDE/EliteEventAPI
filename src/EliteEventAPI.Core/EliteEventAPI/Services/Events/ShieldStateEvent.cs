using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class ShieldStateEvent : EventModelBase
    {
        [JsonProperty("ShieldsUp")]
        public bool ShieldsUp { get; internal set; }
    }
}
