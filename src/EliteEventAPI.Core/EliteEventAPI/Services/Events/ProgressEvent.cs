using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public partial class ProgressEvent : EventModelBase
    {
        public override string Eventname => "Progress";

        [JsonProperty]
        public long Combat { get; internal set; }

        [JsonProperty]
        public long Trade { get; internal set; }

        [JsonProperty]
        public long Explore { get; internal set; }

        [JsonProperty]
        public long Empire { get; internal set; }

        [JsonProperty]
        public long Federation { get; internal set; }

        [JsonProperty]
        public long Cqc { get; internal set; }
    }
}