using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteEventAPI.Core.Events
{
    public sealed class Fuel
    {
        [JsonProperty]
        public double FuelMain { get; internal set; }

        [JsonProperty]
        public double FuelReservoir { get; internal set; }
    }
}
