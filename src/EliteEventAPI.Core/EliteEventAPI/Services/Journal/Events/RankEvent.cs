using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class RankEvent : EventModelBase
    {
        [JsonProperty]
        public long Combat { get; internal set; }

        [JsonProperty]
        public long Trade { get; internal set; }

        [JsonProperty]
        public long Explore { get; internal set; }

        [JsonProperty]
        public long Empire { get; internal set; }

        [JsonProperty]
        public long Federation { get; internal set; }

        [JsonProperty]
        public long Cqc { get; internal set; }
    }
}
