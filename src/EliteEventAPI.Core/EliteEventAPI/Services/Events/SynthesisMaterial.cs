﻿using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public class SynthesisMaterial
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty("Name_Localised", NullValueHandling = NullValueHandling.Ignore)]
        public string NameLocalised { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }
    }
}