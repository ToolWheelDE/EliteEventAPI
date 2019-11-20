using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    internal sealed class InternalMarketEvent : EventModelBase
    {
        protected internal override string Eventname => "Market";

        [JsonProperty]
        public long MarketID { get; internal set; }

        [JsonProperty]
        public string StationName { get; internal set; }

        [JsonProperty]
        public string StarSystem { get; internal set; }
    }
}
