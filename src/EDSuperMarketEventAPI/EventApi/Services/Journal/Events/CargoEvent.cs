using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class CargoEvent : EventModelBase
    {
        protected internal override string Eventname => "*Cargo";

        [JsonProperty]
        public string Vessel { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }

        [JsonProperty]
        public Inventory[] Inventory { get; internal set; }
    }
}
