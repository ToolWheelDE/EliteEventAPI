using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class USSDropEvent : EventModelBase
    {
        [JsonProperty]
        public string UssType { get; internal set; }

        [JsonProperty("USSType_Localised")]
        public string UssTypeLocalised { get; internal set; }

        [JsonProperty]
        public long UssThreat { get; internal set; }
    }
}
