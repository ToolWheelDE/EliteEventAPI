using Newtonsoft.Json;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class JetConeBoostEvent : EventModelBase
    {
        [JsonProperty]
        public double BoostValue { get; internal set; }
    }
}