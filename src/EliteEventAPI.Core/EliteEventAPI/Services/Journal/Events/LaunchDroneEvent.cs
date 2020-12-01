using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class LaunchDroneEvent : EventModelBase
    {
        [JsonProperty]
        public string Type { get; internal set; }
    }
}
