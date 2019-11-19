using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class FriendsEvent : EventModelBase
    {
        protected internal override string Eventname => "Friends";

        [JsonProperty]
        public string Status { get; internal set; }

        [JsonProperty]
        public string Name { get; internal set; }
    }
}
