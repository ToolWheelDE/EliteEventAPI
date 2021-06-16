using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class ScannedEvent : EventModelBase
    {
        [JsonProperty("ScanType")]
        public string ScanType { get; internal set; }
    }
}
