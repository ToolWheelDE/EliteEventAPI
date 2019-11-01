using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class Ring
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public string RingClass { get; internal set; }

        [JsonProperty]
        public double MassMt { get; internal set; }

        [JsonProperty]
        public double InnerRad { get; internal set; }

        [JsonProperty]
        public double OuterRad { get; internal set; }
    }
}
