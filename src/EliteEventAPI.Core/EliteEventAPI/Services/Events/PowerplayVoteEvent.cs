using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class PowerplayVoteEvent : EventModelBase
    {
        [JsonProperty]
        public string Power { get; internal set; }

        [JsonProperty]
        public long Votes { get; internal set; }

        [JsonProperty]
        public long VoteToConsolidate { get; internal set; }
    }
}
