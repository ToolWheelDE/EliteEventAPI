using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class SendTextEvent : EventModelBase
    {
        [JsonProperty]
        public string To { get; internal set; }

        [JsonProperty("To_Localised")]
        public string ToLocalised { get; internal set; }

        [JsonProperty]
        public string Message { get; internal set; }
    }
}
