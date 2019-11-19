using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class DatalinkScanEvent : EventModelBase
    {
        protected internal override string Eventname => "DatalinkScan";

        [JsonProperty]
        public string Message { get; internal set; }

        [JsonProperty("Message_Localised")]
        public string MessageLocalised { get; internal set; }
    }
}
