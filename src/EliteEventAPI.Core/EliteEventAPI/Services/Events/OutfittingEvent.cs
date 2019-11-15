using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    internal sealed class OutfittingEvent : EventModelBase
    {
        protected internal override string Eventname => "*Outfitting";

        [JsonProperty]
        public long MarketID { get; internal set; }

        [JsonProperty]
        public string StationName { get; internal set; }

        [JsonProperty]
        public string StarSystem { get; internal set; }

        public bool Horizons { get; internal set; }

        public OutfitItem[] Items { get; internal set; }
    }
}
