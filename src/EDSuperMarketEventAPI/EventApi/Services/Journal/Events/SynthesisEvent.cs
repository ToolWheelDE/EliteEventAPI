﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class SynthesisEvent : EventModelBase
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public SynthesisMaterial[] Materials { get; internal set; }
    }
}
