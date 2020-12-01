using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class ShieldStateEvent : EventModelBase
    {
        [JsonProperty("ShieldsUp")]
        public bool ShieldsUp { get; internal set; }
    }
}
