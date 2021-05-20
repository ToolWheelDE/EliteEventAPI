using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteEventAPI.Services.Journal.Events
{
    public class SupercruiseEntryEvent : EventModelBase
    {
        [JsonProperty]
        public bool Taxi { get; internal set; }

        [JsonProperty]
        public bool Multicrew { get; internal set; }

        [JsonProperty]
        public string StarSystem { get; internal set; }

        [JsonProperty]
        public long SystemAddress { get; internal set; }
    }
}