﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class ApproachSettlementEvent : EventModelBase
    {
        protected internal override string Eventname => "ApproachSettlement";

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; internal set; }

        [JsonProperty]
        public long MarketId { get; internal set; }

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public long BodyId { get; internal set; }

        [JsonProperty]
        public string BodyName { get; internal set; }

        [JsonProperty]
        public double Latitude { get; internal set; }

        [JsonProperty]
        public double Longitude { get; internal set; }
    }
}