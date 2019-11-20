using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class EngineerCraftEvent : EventModelBase
    {
        [JsonProperty]
        public string Slot { get; internal set; }

        [JsonProperty]
        public string Module { get; internal set; }

        [JsonProperty]
        public string ApplyExperimentalEffect { get; internal set; }

        [JsonProperty]
        public Ingredient[] Ingredients { get; internal set; }

        [JsonProperty]
        public string Engineer { get; internal set; }

        [JsonProperty]
        public long EngineerId { get; internal set; }

        [JsonProperty]
        public long BlueprintId { get; internal set; }

        [JsonProperty]
        public string BlueprintName { get; internal set; }

        [JsonProperty]
        public long Level { get; internal set; }

        [JsonProperty]
        public double Quality { get; internal set; }

        [JsonProperty]
        public string ExperimentalEffect { get; internal set; }

        [JsonProperty("ExperimentalEffect_Localised")]
        public string ExperimentalEffectLocalised { get; internal set; }

        [JsonProperty]
        public Modifier[] Modifiers { get; internal set; }
    }
}
