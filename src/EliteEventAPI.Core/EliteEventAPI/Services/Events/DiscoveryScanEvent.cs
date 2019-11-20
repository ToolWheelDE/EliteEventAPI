using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class DiscoveryScanEvent : EventModelBase
    {
        protected internal override string Eventname => "DiscoveryScan";

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public long Bodies { get; internal set; }
    }
}
