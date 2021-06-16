﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class DisbandedSquadronEvent : EventModelBase
    {
        [JsonProperty]
        public string SquadronName { get; internal set; }
    }
}
