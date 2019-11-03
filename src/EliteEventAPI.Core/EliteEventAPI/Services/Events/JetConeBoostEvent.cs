using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public partial class JetConeBoostEvent : EventModelBase
    {
        public override string Eventname => "JetConeBoost";

        [JsonProperty]
        public double BoostValue { get; internal set; }
    }
}