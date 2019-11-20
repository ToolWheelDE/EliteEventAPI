using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class EndCrewSessionEvent : EventModelBase
    {
        protected internal override string Eventname => "EndCrewSession";

        [JsonProperty]
        public bool OnCrime { get; internal set; }
    }
}
