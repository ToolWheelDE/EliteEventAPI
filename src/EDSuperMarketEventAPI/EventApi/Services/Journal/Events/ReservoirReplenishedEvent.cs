using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class ReservoirReplenishedEvent : EventModelBase
    {
        [JsonProperty]
        public double FuelMain { get; set; }

        [JsonProperty]
        public double FuelReservoir { get; set; }
    }
}
