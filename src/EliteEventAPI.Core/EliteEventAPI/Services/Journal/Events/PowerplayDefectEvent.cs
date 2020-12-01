using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class PowerplayDefectEvent : EventModelBase
    {
        [JsonProperty]
        public string FromPower { get; internal set; }

        [JsonProperty]
        public string ToPower { get; internal set; }
    }
}
