using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class DisembarkEvent : EventModelBase
    {
        [JsonProperty]
        public bool SRV { get; internal set; }

        [JsonProperty]
        public bool Taxi { get; internal set; }

        [JsonProperty]
        public bool Multicrew { get; internal set; }

        [JsonProperty]
        public long ID { get; internal set; }

        [JsonProperty]
        public string StarSystem { get; internal set; }

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public string Body { get; internal set; }

        [JsonProperty]
        public long BodyID { get; internal set; }

        [JsonProperty]
        public bool OnStation { get; internal set; }

        [JsonProperty]
        public bool OnPlanet { get; internal set; }

        [JsonProperty]
        public string StationName { get; internal set; }

        [JsonProperty]
        public string StationType { get; internal set; }

        [JsonProperty]
        public long MarketID { get; internal set; }
    }
}
