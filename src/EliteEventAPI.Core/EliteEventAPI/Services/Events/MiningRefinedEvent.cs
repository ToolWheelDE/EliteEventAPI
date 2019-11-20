﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class MiningRefinedEvent : EventModelBase
    {
        protected internal override string Eventname => "MiningRefined";

        [JsonProperty]
        public string Type { get; internal set; }

        [JsonProperty("Type_Localised")]
        public string TypeLocalised { get; internal set; }
    }
}