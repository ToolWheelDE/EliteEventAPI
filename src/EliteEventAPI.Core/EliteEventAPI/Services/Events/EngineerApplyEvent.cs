using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class EngineerApplyEvent : EventModelBase
    {
        [JsonProperty]
        public string Engineer { get; internal set; }

        [JsonProperty]
        public string Blueprint { get; internal set; }

        [JsonProperty]
        public long Level { get; internal set; }

        [JsonProperty]
        public string Override { get; internal set; }
    }
}
