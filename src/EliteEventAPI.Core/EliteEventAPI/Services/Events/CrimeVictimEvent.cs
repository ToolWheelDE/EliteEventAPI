using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class CrimeVictimEvent : EventModelBase
    {
        protected internal override string Eventname => "CrimeVictim";

        [JsonProperty]
        public string Offender { get; internal set; }

        [JsonProperty]
        public string CrimeType { get; internal set; }

        [JsonProperty]
        public long Bounty { get; internal set; }
    }
}
