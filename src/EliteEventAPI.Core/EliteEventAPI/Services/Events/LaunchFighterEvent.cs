using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class LaunchFighterEvent : EventModelBase
    {
        [JsonProperty]
        public string Loadout { get; internal set; }

        [JsonProperty]
        public bool PlayerControlled { get; internal set; }
    }
}
