using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class JetConeDamageEvent : EventModelBase
    {
        [JsonProperty]
        public string Module { get; internal set; }

        [JsonProperty("Module_Localised")]
        public string ModuleLocalised { get; internal set; }
    }
}