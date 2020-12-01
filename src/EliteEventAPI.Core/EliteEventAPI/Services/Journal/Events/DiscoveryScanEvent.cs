using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class DiscoveryScanEvent : EventModelBase
    {
        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public long Bodies { get; internal set; }
    }
}
