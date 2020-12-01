using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class ReceiveTextEvent : EventModelBase
    {
        [JsonProperty]
        public string From { get; internal set; }

        [JsonProperty("From_Localised")]
        public string FromLocalised { get; internal set; }

        [JsonProperty]
        public string Message { get; internal set; }

        [JsonProperty("Message_Localised")]
        public string MessageLocalised { get; internal set; }

        [JsonProperty]
        public string Channel { get; internal set; }
    }
}
