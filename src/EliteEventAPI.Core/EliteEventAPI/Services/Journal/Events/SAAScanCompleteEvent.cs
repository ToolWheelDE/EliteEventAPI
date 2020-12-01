using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class SAAScanCompleteEvent : EventModelBase
    {
        [JsonProperty]
        public string BodyName { get; internal set; }

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public long BodyId { get; internal set; }

        [JsonProperty]
        public long ProbesUsed { get; internal set; }

        [JsonProperty]
        public long EfficiencyTarget { get; internal set; }
    }
}
