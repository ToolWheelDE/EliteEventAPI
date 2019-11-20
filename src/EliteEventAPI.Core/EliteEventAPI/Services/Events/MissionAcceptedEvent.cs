using Newtonsoft.Json;
using System;

namespace EliteEventAPI.Services.Events
{
    public partial class MissionAcceptedEvent : EventModelBase
    {
        [JsonProperty]
        public string Faction { get; internal set; }

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty("LocalisedName")]
        public string LocalisedName { get; internal set; }

        [JsonProperty]
        public string Commodity { get; internal set; }

        [JsonProperty("Commodity_Localised")]
        public string CommodityLocalised { get; internal set; }

        [JsonProperty]
        public long Count { get; internal set; }

        [JsonProperty]
        public string DestinationSystem { get; internal set; }

        [JsonProperty]
        public DateTime Expiry { get; internal set; }

        [JsonProperty]
        public string Influence { get; internal set; }

        [JsonProperty]
        public string Reputation { get; internal set; }

        [JsonProperty]
        public long Reward { get; internal set; }

        [JsonProperty]
        public long PassengerCount { get; internal set; }

        [JsonProperty]
        public bool PassengerViPs { get; internal set; }

        [JsonProperty]
        public bool PassengerWanted { get; internal set; }

        [JsonProperty]
        public string PassengerType { get; internal set; }

        [JsonProperty]
        public long MissionId { get; internal set; }
    }
}