using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class Parent
    {
        [JsonProperty]
        public long? Null { get; internal set; }

        [JsonProperty]
        public long? Star { get; internal set; }

        [JsonProperty]
        public long? Planet { get; internal set; }

        [JsonProperty]
        public long? Ring { get; internal set; }
    }
}
