using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class QuitACrewEvent : EventModelBase
    {
        [JsonProperty]
        public string Captain { get; internal set; }
    }
}
