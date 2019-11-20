﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class SellDronesEvent : EventModelBase
    {
        [JsonProperty]
        public string Type { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }

        [JsonProperty]
        public long SellPrice { get; internal set; }

        [JsonProperty]
        public long TotalSale { get; internal set; }
    }
}
