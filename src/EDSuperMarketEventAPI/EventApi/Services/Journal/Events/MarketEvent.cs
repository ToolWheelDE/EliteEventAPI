using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class MarketEvent : EventModelBase
    {
        protected internal override string Eventname => "*Market";

        [JsonProperty]
        public long MarketID { get; internal set; }

        [JsonProperty]
        public string StationName { get; internal set; }

        [JsonProperty]
        public string StarSystem { get; internal set; }

        [JsonProperty]
        public MarketItem[] Items { get; internal set; }
    }
}
