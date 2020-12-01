using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class DatalinkScanEvent : EventModelBase
    {
        [JsonProperty]
        public string Message { get; internal set; }

        [JsonProperty("Message_Localised")]
        public string MessageLocalised { get; internal set; }
    }
}
