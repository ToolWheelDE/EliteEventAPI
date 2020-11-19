using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class SAASignalsFoundEvent : EventModelBase
    {
        [JsonProperty]
        public string BodyName { get; internal set; }

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public long BodyID { get; internal set; }

        [JsonProperty]
        public SAASignal[] Signals { get; internal set; }
    }
}