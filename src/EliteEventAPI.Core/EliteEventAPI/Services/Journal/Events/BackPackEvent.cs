using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public class BackPackEvent : EventModelBase
    {
        protected internal override string Eventname => "*BackPack";

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
