using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class ScannedEvent : EventModelBase
    {
        [JsonProperty("ScanType")]
        public string ScanType { get; internal set; }
    }
}
