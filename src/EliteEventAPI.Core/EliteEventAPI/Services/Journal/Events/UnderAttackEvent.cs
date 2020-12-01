using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class UnderAttackEvent : EventModelBase
    {
        [JsonProperty]
        public string Target { get; internal set; }
    }
}
