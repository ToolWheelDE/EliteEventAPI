using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class CrewHireEvent : EventModelBase
    {
        protected internal override string Eventname => "CrewHire";

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long CrewId { get; internal set; }

        [JsonProperty]
        public string Faction { get; internal set; }

        [JsonProperty]
        public long Cost { get; internal set; }

        [JsonProperty]
        public long CombatRank { get; internal set; }
    }
}
