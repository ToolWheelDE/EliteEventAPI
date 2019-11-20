using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class QuitACrewEvent : EventModelBase
    {
        protected internal override string Eventname => "QuitACrew";

        [JsonProperty]
        public string Captain { get; internal set; }
    }
}
