﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class ProspectedAsteroidEvent : EventModelBase
    {
        [JsonProperty]
        public ProspectedMaterial[] Materials { get; set; }

        [JsonProperty]
        public string MotherlodeMaterial { get; set; }

        [JsonProperty("MotherlodeMaterial_Localised")]
        public string MotherlodeMaterialLocalised { get; set; }

        [JsonProperty]
        public string Content { get; set; }

        [JsonProperty("Content_Localised")]
        public string ContentLocalised { get; set; }

        [JsonProperty]
        public long Remaining { get; set; }
    }
}