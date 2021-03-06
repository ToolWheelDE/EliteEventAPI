﻿using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class TechnologyBrokerEvent : EventModelBase
    {
        [JsonProperty]
        public string BrokerType { get; internal set; }

        [JsonProperty]
        public long MarketId { get; internal set; }

        [JsonProperty]
        public ItemsUnlocked[] ItemsUnlocked { get; internal set; }

        [JsonProperty]
        public Commodity[] Commodities { get; internal set; }

        [JsonProperty]
        public Commodity[] Materials { get; internal set; }
    }
}
