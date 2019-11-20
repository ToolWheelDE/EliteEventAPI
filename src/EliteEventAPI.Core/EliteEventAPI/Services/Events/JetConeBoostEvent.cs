using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class JetConeBoostEvent : EventModelBase
    {
        [JsonProperty]
        public double BoostValue { get; internal set; }
    }
}