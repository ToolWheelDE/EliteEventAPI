using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class BuyExplorationDataEvent : EventModelBase
    {
        protected internal override string Eventname => "BuyExplorationData";

        [JsonProperty]
        public string System { get; internal set; }

        [JsonProperty]
        public long Cost { get; internal set; }
    }
}
