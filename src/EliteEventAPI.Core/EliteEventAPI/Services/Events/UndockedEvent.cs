using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteEventAPI.Services.Events
{
    public class UndockedEvent : EventModelBase
    {
        public override string Eventname => "Undocked";

        [JsonProperty]
        public string StationName { get; internal set; }

        [JsonProperty]
        public string StationType { get; internal set; }

        [JsonProperty]
        public long MarketId { get; internal set; }
    }
}
