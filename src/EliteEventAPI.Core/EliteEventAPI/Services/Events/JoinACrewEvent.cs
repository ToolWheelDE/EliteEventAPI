﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class JoinACrewEvent : EventModelBase
    {
        protected internal override string Eventname => "JoinACrew";

        [JsonProperty]
        public string Captain { get; internal set; }
    }
}
