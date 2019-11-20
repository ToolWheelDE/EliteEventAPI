using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class WingJoinEvent : EventModelBase
    {
        [JsonProperty]
        public string[] Others { get; internal set; }
    }
}
