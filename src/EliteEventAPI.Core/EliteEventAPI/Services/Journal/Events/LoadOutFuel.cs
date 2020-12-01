using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class LoadOutFuel
    {
        [JsonProperty]
        public double Main { get; internal set; }

        [JsonProperty]
        public double Reserve { get; internal set; }
    }
}
