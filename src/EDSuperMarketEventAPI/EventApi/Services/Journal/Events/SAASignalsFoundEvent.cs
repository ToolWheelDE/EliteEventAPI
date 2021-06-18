using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class SAASignalsFoundEvent : EventModelBase
    {
        [JsonProperty]
        public string BodyName { get; internal set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StarSystem { get; internal set; }

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double[] StarPos { get; internal set; }

        [JsonProperty]
        public int BodyID { get; internal set; }

        [JsonProperty]
        public SAASignal[] Signals { get; internal set; }
    }
}