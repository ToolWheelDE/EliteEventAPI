using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class ModulesInfoEvent : EventModelBase
    {
        protected internal override string Eventname => "*ModulesInfo";

        [JsonProperty]
        public ModuleSlot[] Modules { get; internal set; }
    }
}
