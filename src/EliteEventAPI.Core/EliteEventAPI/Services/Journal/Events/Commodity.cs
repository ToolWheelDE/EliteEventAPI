﻿using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class Commodity
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }

        [JsonProperty("Category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; internal set; }
    }
}