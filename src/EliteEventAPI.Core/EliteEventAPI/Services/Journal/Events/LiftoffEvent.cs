﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class LiftoffEvent : EventModelBase
    {
        [JsonProperty]
        public bool PlayerControlled { get; internal set; }

        [JsonProperty]
        public double Latitude { get; internal set; }

        [JsonProperty]
        public double Longitude { get; internal set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string NearestDestination { get; internal set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string NearestDestination_Localised { get; internal set; }
    }
}
