﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class ModuleBuyEvent : EventModelBase
    {
        protected internal override string Eventname => "ModuleBuy";

        [JsonProperty]
        public string Slot { get; internal set; }

        [JsonProperty]
        public string SellItem { get; internal set; }

        [JsonProperty("SellItem_Localised")]
        public string SellItemLocalised { get; internal set; }

        [JsonProperty]
        public long SellPrice { get; internal set; }

        [JsonProperty]
        public string BuyItem { get; internal set; }

        [JsonProperty("BuyItem_Localised")]
        public string BuyItemLocalised { get; internal set; }

        [JsonProperty]
        public long MarketId { get; internal set; }

        [JsonProperty]
        public long BuyPrice { get; internal set; }

        [JsonProperty]
        public string Ship { get; internal set; }

        [JsonProperty]
        public long ShipId { get; internal set; }
    }
}
