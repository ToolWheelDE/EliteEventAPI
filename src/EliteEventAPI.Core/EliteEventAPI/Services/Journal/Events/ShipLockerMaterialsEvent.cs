using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    
    public sealed class ShipLockerMaterialsEvent : EventModelBase
    {
        [JsonProperty]
        public object[] Items { get; internal set; }

        [JsonProperty]
        public object[] Components { get; internal set; }

        [JsonProperty]
        public object[] Consumables { get; internal set; }

        [JsonProperty]
        public object[] Data { get; internal set; }
    }
}
