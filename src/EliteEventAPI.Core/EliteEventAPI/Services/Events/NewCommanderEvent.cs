using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class NewCommanderEvent : EventModelBase
    {
        protected internal override string Eventname => "NewCommander";

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public string Package { get; internal set; }
    }
}
