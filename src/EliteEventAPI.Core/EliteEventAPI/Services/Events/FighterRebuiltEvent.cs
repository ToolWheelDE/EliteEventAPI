using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class FighterRebuiltEvent : EventModelBase
    {
        protected internal override string Eventname => "FighterRebuilt";

        [JsonProperty]
        public string Loadout { get; internal set; }
    }
}
