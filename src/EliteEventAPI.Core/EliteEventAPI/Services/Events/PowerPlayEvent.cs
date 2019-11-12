using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class PowerPlayEvent : EventModelBase
    {
        protected internal override string Eventname => "Powerplay";

        [JsonProperty]
        public string Power { get; internal set; }

        [JsonProperty]
        public long Rank { get; internal set; }

        [JsonProperty]
        public long Merits { get; internal set; }

        [JsonProperty]
        public long Votes { get; internal set; }

        [JsonProperty]
        public long TimePledged { get; internal set; }
    }
}
