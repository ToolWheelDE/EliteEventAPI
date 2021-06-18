﻿using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    internal sealed class InternalOutfittingEvent : EventModelBase
    {
        protected internal override string Eventname => "Outfitting";

        [JsonProperty]
        public long MarketID { get; internal set; }

        [JsonProperty]
        public string StationName { get; internal set; }

        [JsonProperty]
        public string StarSystem { get; internal set; }
    }
}
