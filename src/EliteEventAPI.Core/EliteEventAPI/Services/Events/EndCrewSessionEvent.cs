using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class EndCrewSessionEvent : EventModelBase
    {
        [JsonProperty]
        public bool OnCrime { get; internal set; }
    }
}
