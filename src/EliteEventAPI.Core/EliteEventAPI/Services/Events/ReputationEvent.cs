using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public partial class ReputationEvent : EventModelBase
    {
        public override string Eventname => "Reputation";

        [JsonProperty("Empire")]
        public double Empire { get; internal set; }

        [JsonProperty("Federation")]
        public double Federation { get; internal set; }

        [JsonProperty("Independent")]
        public double Independent { get; internal set; }

        [JsonProperty("Alliance")]
        public double Alliance { get; internal set; }


    }
    }
