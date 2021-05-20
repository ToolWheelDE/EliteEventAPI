﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class CrewAssignEvent : EventModelBase
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long CrewId { get; internal set; }

        [JsonProperty]
        public string Role { get; internal set; }
    }
}