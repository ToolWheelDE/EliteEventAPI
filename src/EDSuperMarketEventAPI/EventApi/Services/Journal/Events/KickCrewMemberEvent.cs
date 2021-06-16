﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class KickCrewMemberEvent : EventModelBase
    {
        [JsonProperty]
        public string Crew { get; internal set; }

        [JsonProperty]
        public bool OnCrime { get; internal set; }
    }
}
