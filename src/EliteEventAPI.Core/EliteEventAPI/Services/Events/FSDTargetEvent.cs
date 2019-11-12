using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class FSDTargetEvent : EventModelBase
    {
        protected internal override string Eventname => "FSDTarget";

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public int RemainingJumpsInRoute { get; internal set; }
    }
}