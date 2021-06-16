using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class PVPKillEvent : EventModelBase
    {
        [JsonProperty]
        public string Victim { get; internal set; }

        [JsonProperty]
        public long CombatRank { get; internal set; }
    }
}
