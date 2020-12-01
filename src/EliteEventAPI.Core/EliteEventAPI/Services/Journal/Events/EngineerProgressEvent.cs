using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class EngineerProgressEvent : EventModelBase
    {
        [JsonProperty]
        public Engineer[] Engineers { get; internal set; }

        [JsonProperty]
        public string Engineer { get; internal set; }

        [JsonProperty]
        public long EngineerID { get; internal set; }

        [JsonProperty]
        public int Rank { get; internal set; }

        [JsonProperty]
        public int Progress { get; internal set; }

        [JsonProperty]
        public double RankProgress { get; internal set; }

        public bool IsUpdate { get => Engineers == null; }
    }
}
