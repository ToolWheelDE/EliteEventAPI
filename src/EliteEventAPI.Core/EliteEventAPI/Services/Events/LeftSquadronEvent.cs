﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class LeftSquadronEvent : EventModelBase
    {
        [JsonProperty]
        public string SquadronName { get; internal set; }
    }
}
