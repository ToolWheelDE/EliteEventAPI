using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class FriendsEvent : EventModelBase
    {
        [JsonProperty]
        public string Status { get; internal set; }

        [JsonProperty]
        public string Name { get; internal set; }
    }
}
