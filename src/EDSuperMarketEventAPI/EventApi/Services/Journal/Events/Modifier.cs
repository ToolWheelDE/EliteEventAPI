﻿using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class Modifier
    {
        [JsonProperty]
        public string Label { get; internal set; }

        [JsonProperty]
        public double Value { get; internal set; }

        [JsonProperty]
        public double OriginalValue { get; internal set; }

        [JsonProperty]
        public long LessIsGood { get; internal set; }
    }
}