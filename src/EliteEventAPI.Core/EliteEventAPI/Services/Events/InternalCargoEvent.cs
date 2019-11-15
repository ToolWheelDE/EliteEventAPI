﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    internal sealed class InternalCargoEvent : EventModelBase
    {
        protected internal override string Eventname => "Cargo";

        [JsonProperty]
        public string Vessel { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }

        [JsonProperty]
        public Inventory[] Inventory { get; internal set; }
    }
}
