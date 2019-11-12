using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class MusicEvent : EventModelBase
    {
        protected internal override string Eventname => "Music";

        [JsonProperty]
        public string MusicTrack { get; internal set; }
    }
}
