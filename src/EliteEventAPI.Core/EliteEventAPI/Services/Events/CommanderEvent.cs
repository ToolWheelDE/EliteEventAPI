using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class CommanderEvent : EventModelBase
    {
        public override string Eventname => "Commander";

        [JsonProperty]
        public string FID { get; internal set; }

        [JsonProperty]
        public string Name { get; internal set; }
    }
}
