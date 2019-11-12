using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public class LoadOutEvent : EventModelBase
    {
        protected internal override string Eventname => "Loadout";

        [JsonProperty]
        public string Ship { get; internal set; }

        [JsonProperty]
        public long ShipId { get; internal set; }

        [JsonProperty]
        public string ShipName { get; internal set; }

        [JsonProperty]
        public string ShipIdent { get; internal set; }

        [JsonProperty]
        public long HullValue { get; internal set; }

        [JsonProperty]
        public double HullHealth { get; internal set; }

        [JsonProperty]
        public long ModulesValue { get; internal set; }

        [JsonProperty]
        public long UnladenMass { get; internal set; }

        [JsonProperty]
        public LoadOutFuel FuelCapacity { get; internal set; }

        [JsonProperty]
        public int CargoCapacity { get; internal set; }

        [JsonProperty]
        public double MaxJumpRange { get; internal set; }

        [JsonProperty]
        public bool Hot { get; internal set; }

        [JsonProperty]
        public long Rebuy { get; internal set; }

        [JsonProperty]
        public ShipModule[] Modules { get; internal set; }
    }
}