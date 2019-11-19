using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class AsteroidCrackedEvent : EventModelBase
    {
        protected internal override string Eventname => "AsteroidCracked";

        [JsonProperty]
        public string Body { get; internal set; }
    }
}
