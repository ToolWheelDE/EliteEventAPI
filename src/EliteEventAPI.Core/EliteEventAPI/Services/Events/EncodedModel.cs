﻿using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class EncodedModel
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }
    }
}