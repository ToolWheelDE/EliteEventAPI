using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class AfmuRepairsEvent : EventModelBase
    {
        [JsonProperty]
        public string Module { get; internal set; }

        [JsonProperty("Module_Localised")]
        public string ModuleLocalised { get; internal set; }

        [JsonProperty]
        public bool FullyRepaired { get; internal set; }

        [JsonProperty]
        public double Health { get; internal set; }
    }
}