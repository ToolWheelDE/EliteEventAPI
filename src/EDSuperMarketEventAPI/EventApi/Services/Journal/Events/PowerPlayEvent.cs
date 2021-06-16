using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class PowerplayEvent : EventModelBase
    {
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
