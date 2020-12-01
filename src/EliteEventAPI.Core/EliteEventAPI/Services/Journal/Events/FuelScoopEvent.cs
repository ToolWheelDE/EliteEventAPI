using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteEventAPI.Services.Journal.Events
{
    public class FuelScoopEvent : EventModelBase
    {
        [JsonProperty]
        public double Scooped { get; internal set; }

        [JsonProperty]
        public double Total { get; internal set; }
    }
}
