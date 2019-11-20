using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class PassengersEvent : EventModelBase
    {
        protected internal override string Eventname => "Passengers";

        [JsonProperty]
        public Manifest[] Manifest { get; internal set; }
    }
}
