using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class ResurrectEvent : EventModelBase
    {
        [JsonProperty]
        public string Option { get; internal set; }

        [JsonProperty]
        public long Cost { get; internal set; }

        [JsonProperty]
        public bool Bankrupt { get; internal set; }
    }
}
