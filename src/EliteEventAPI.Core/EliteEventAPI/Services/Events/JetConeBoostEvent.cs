using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class JetConeBoostEvent : EventModelBase
    {
        protected internal override string Eventname => "JetConeBoost";

        [JsonProperty]
        public double BoostValue { get; internal set; }
    }
}