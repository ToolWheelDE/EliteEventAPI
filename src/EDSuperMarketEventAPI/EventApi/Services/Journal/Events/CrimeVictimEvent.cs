using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class CrimeVictimEvent : EventModelBase
    {
        [JsonProperty]
        public string Offender { get; internal set; }

        [JsonProperty]
        public string CrimeType { get; internal set; }

        [JsonProperty]
        public long Bounty { get; internal set; }
    }
}
