using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class RepairDroneEvent : EventModelBase
    {
        [JsonProperty]
        public double HullRepaired { get; internal set; }

        [JsonProperty]
        public double CockpitRepaired { get; internal set; }
    }
}
