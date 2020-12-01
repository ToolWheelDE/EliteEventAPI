using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class Composition
    {
        [JsonProperty]
        public double Ice { get; internal set; }

        [JsonProperty]
        public double Rock { get; internal set; }

        [JsonProperty]
        public double Metal { get; internal set; }
    }
}
