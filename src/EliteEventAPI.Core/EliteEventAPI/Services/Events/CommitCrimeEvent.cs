using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class CommitCrimeEvent : EventModelBase
    {
        protected internal override string Eventname => "CommitCrime";

        [JsonProperty]
        public string CrimeType { get; internal set; }

        [JsonProperty]
        public string Faction { get; internal set; }

        [JsonProperty]
        public string Victim { get; internal set; }

        [JsonProperty("Victim_Localised")]
        public string VictimLocalised { get; internal set; }

        [JsonProperty]
        public long Bounty { get; internal set; }
    }
}
