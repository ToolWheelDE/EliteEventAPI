using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    
    public sealed class ShipLockerEvent : EventModelBase
    {
        [JsonProperty]
        public ShipLockerItem[] Items { get; internal set; }

        [JsonProperty]
        public ShipLockerItem[] Components { get; internal set; }

        [JsonProperty]
        public ShipLockerItem[] Consumables { get; internal set; }

        [JsonProperty]
        public ShipLockerItem[] Data { get; internal set; }
    }
}
