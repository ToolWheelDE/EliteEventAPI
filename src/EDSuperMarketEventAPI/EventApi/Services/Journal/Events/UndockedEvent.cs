using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class UndockedEvent : EventModelBase
    {
        [JsonProperty]
        public bool Taxi { get; internal set; }

        [JsonProperty]
        public bool Multicrew { get; internal set; }

        [JsonProperty]
        public string StationName { get; internal set; }

        [JsonProperty]
        public string StationType { get; internal set; }

        [JsonProperty]
        public long MarketId { get; internal set; }
    }
}
