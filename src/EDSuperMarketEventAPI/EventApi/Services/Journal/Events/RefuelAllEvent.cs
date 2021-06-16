using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class RefuelAllEvent : EventModelBase
    {
        [JsonProperty]
        public int Cost { get; internal set; }

        [JsonProperty]
        public double Amount { get; internal set; }
    }
}
