using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class RepairDroneEvent : EventModelBase
    {
        [JsonProperty]
        public double HullRepaired { get; internal set; }

        [JsonProperty]
        public double CockpitRepaired { get; internal set; }
    }
}
