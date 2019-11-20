using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class LaunchSRVEvent : EventModelBase
    {
        protected internal override string Eventname => "LaunchSRV";

        [JsonProperty]
        public string Loadout { get; internal set; }

        [JsonProperty]
        public bool PlayerControlled { get; internal set; }
    }
}
