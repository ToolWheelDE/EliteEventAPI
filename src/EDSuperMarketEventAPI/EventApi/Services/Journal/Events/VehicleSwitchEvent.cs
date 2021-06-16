using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class VehicleSwitchEvent : EventModelBase
    {
        [JsonProperty]
        public string To { get; internal set; }
    }
}
