using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class ReservoirReplenishedEvent : EventModelBase
    {
        [JsonProperty]
        public double FuelMain { get; set; }

        [JsonProperty]
        public double FuelReservoir { get; set; }
    }
}
