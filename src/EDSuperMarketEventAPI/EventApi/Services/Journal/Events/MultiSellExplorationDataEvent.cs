﻿using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class MultiSellExplorationDataEvent : EventModelBase
    {
        [JsonProperty]
        public DiscovererData[] Discovered { get; internal set; }

        [JsonProperty]
        public int BaseValue { get; internal set; }

        [JsonProperty]
        public int Bonus { get; internal set; }

        [JsonProperty]
        public int TotalEarnings { get; internal set; }
    }
}
