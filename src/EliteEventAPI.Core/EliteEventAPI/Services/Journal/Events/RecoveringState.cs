﻿using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public class RecoveringState
    {
        [JsonProperty]
        public string  State  {get; internal set;}

        [JsonProperty]
        public double? Trend { get; internal set; }
    }
}