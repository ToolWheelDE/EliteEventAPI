using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class JetConeDamageEvent : EventModelBase
    {
        public override string Eventname => "JetConeDamage";

        [JsonProperty]
        public string Module { get; internal set; }

        [JsonProperty("Module_Localised")]
        public string ModuleLocalised { get; internal set; }
    }
}