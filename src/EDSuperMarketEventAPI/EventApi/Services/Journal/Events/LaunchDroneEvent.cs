using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class LaunchDroneEvent : EventModelBase
    {
        [JsonProperty]
        public string Type { get; internal set; }
    }
}
