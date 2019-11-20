using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class VehicleSwitchEvent : EventModelBase
    {
        [JsonProperty]
        public string To { get; internal set; }
    }
}
