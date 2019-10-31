using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Core.Events
{
    public sealed class CargoEvent : EventModelBase
    {
        public override string Eventname => "Cargo";

        [JsonProperty]
        public string Vessel { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }

        [JsonProperty]
        public List<Inventory> Inventory { get; internal set; }
    }
}
