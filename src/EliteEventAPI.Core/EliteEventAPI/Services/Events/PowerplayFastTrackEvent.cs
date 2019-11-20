using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class PowerplayFastTrackEvent : EventModelBase
    {
        protected internal override string Eventname => "PowerplayFastTrack";

        [JsonProperty]
        public string Power { get; internal set; }

        [JsonProperty]
        public long Cost { get; internal set; }
    }
}
