using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class ModuleInfoEvent : EventModelBase
    {
        protected internal override string Eventname => "*ModuleInfo";

        [JsonProperty]
        public ModuleSlot[] Modules { get; internal set; }
    }
}
