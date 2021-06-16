using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class JetConeBoostEvent : EventModelBase
    {
        [JsonProperty]
        public double BoostValue { get; internal set; }
    }
}