﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class FactionKillBondEvent : EventModelBase
    {
        protected internal override string Eventname => "FactionKillBond";

        [JsonProperty]
        public long Reward { get; internal set; }

        [JsonProperty]
        public string AwardingFaction { get; internal set; }

        [JsonProperty("AwardingFaction_Localised")]
        public string AwardingFactionLocalised { get; internal set; }

        [JsonProperty]
        public string VictimFaction { get; internal set; }

        [JsonProperty("VictimFaction_Localised")]
        public string VictimFactionLocalised { get; internal set; }
    }
}