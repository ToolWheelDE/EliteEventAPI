using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class LeaveBodyEvent : EventModelBase
    {
        protected internal override string Eventname => "LeaveBody";

        [JsonProperty]
        public string StarSystem { get; internal set; }

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public string Body { get; internal set; }

        [JsonProperty]
        public int BodyID { get; internal set; }
    }
}