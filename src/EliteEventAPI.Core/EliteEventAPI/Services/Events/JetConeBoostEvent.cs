using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class JetConeBoostEvent : EventModelBase
    {
        public override string Eventname => "JetConeBoost";

        [JsonProperty]
        public double BoostValue { get; internal set; }
    }
}