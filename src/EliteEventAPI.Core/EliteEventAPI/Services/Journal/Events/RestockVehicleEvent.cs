using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class RestockVehicleEvent : EventModelBase
    {
        [JsonProperty]
        public string Type { get; internal set; }

        [JsonProperty]
        public string Loadout { get; internal set; }

        [JsonProperty]
        public long Cost { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }
    }
}
