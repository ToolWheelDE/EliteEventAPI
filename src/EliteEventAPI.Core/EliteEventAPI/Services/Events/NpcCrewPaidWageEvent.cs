using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class NpcCrewPaidWageEvent : EventModelBase
    {
        [JsonProperty]
        public string NpcCrewName { get; internal set; }

        [JsonProperty]
        public long NpcCrewId { get; internal set; }

        [JsonProperty]
        public long Amount { get; internal set; }
    }
}
