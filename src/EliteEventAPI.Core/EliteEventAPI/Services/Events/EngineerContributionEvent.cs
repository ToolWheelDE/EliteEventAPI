using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class EngineerContributionEvent : EventModelBase
    {
        [JsonProperty]
        public string Engineer { get; internal set; }

        [JsonProperty]
        public string Type { get; internal set; }

        [JsonProperty]
        public string Material { get; internal set; }

        [JsonProperty]
        public long Quantity { get; internal set; }

        [JsonProperty]
        public long TotalQuantity { get; internal set; }
    }
}
