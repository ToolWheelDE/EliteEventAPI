using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public partial class FSDTargetEvent : EventModelBase
    {
        public override string Eventname => "FSDTarget";

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public int RemainingJumpsInRoute { get; internal set; }
    }
}