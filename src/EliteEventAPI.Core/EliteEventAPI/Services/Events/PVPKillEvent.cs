using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class PVPKillEvent : EventModelBase
    {
        [JsonProperty]
        public string Victim { get; internal set; }

        [JsonProperty]
        public long CombatRank { get; internal set; }
    }
}
