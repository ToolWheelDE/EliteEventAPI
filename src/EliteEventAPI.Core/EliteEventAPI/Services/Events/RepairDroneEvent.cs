using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class RepairDroneEvent : EventModelBase
    {
        protected internal override string Eventname => "RepairDrone";

        [JsonProperty]
        public double HullRepaired { get; internal set; }

        [JsonProperty]
        public double CockpitRepaired { get; internal set; }
    }
}
