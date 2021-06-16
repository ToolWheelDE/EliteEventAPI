using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class StatusFuel
    {
        [JsonProperty]
        public double FuelMain { get; internal set; }

        [JsonProperty]
        public double FuelReservoir { get; internal set; }
    }
}
