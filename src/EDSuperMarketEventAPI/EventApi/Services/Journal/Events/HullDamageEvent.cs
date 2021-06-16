using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class HullDamageEvent : EventModelBase
    {
        [JsonProperty]
        public double Health { get; internal set; }

        [JsonProperty]
        public bool PlayerPilot { get; internal set; }

        [JsonProperty]
        public bool Fighter { get; internal set; }
    }
}
