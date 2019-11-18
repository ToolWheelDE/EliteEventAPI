using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public class Engineering
    {
        [JsonProperty]
        public string Engineer { get; internal set; }

        [JsonProperty]
        public ulong EngineerId { get; internal set; }

        [JsonProperty]
        public ulong BlueprintId { get; internal set; }

        [JsonProperty]
        public string BlueprintName { get; internal set; }

        [JsonProperty]
        public long Level { get; internal set; }

        [JsonProperty]
        public double Quality { get; internal set; }

        [JsonProperty("ExperimentalEffect", NullValueHandling = NullValueHandling.Ignore)]
        public string ExperimentalEffect { get; internal set; }

        [JsonProperty("ExperimentalEffect_Localised", NullValueHandling = NullValueHandling.Ignore)]
        public string ExperimentalEffectLocalised { get; internal set; }

        [JsonProperty]
        public LoadOutModifier[] Modifiers { get; internal set; }
    }
}
