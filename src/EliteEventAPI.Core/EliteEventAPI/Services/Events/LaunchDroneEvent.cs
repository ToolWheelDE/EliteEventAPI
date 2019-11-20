using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class LaunchDroneEvent : EventModelBase
    {
        [JsonProperty]
        public string Type { get; internal set; }
    }
}
