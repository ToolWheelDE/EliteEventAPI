using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class FighterRebuiltEvent : EventModelBase
    {
        [JsonProperty]
        public string Loadout { get; internal set; }
    }
}
