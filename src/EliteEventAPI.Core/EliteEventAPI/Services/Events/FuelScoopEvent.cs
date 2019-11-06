using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteEventAPI.Services.Events
{
    public class FuelScoopEvent : EventModelBase
    {
        public override string Eventname => "FuelScoop";

        [JsonProperty]
        public double Scooped { get; internal set; }

        [JsonProperty]
        public double Total { get; internal set; }
    }
}
