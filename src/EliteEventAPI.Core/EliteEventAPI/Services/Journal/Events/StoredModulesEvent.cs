using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class StoredModulesEvent : EventModelBase
    {
        [JsonProperty]
        public long MarketID { get; internal set; }

        [JsonProperty]
        public string StationName { get; internal set; }

        [JsonProperty]
        public string StarSystem { get; internal set; }

        [JsonProperty]
        public StoredModule[] Items { get; internal set; }
    }
}
