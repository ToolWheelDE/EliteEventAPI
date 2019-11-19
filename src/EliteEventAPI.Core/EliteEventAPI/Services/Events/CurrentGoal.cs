using Newtonsoft.Json;
using System;

namespace EliteEventAPI.Services.Events
{
    public sealed class CurrentGoal
    {
        [JsonProperty]
        public long Cgid { get; internal set; }

        [JsonProperty]
        public string Title { get; internal set; }

        [JsonProperty]
        public string SystemName { get; internal set; }

        [JsonProperty]
        public string MarketName { get; internal set; }

        [JsonProperty]
        public DateTime Expiry { get; internal set; }

        [JsonProperty]
        public bool IsComplete { get; internal set; }

        [JsonProperty]
        public long CurrentTotal { get; internal set; }

        [JsonProperty]
        public long PlayerContribution { get; internal set; }

        [JsonProperty]
        public long NumContributors { get; internal set; }

        [JsonProperty]
        public long TopRankSize { get; internal set; }

        [JsonProperty]
        public bool PlayerInTopRank { get; internal set; }

        [JsonProperty]
        public string TierReached { get; internal set; }

        [JsonProperty]
        public long PlayerPercentileBand { get; internal set; }

        [JsonProperty]
        public long Bonus { get; internal set; }
    }
}