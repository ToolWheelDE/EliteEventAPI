using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class BuyExplorationDataEvent : EventModelBase
    {
        [JsonProperty]
        public string System { get; internal set; }

        [JsonProperty]
        public long Cost { get; internal set; }
    }
}
