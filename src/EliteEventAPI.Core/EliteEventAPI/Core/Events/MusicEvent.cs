using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Core.Events
{
    public sealed class MusicEvent : EventModelBase
    {
        public override string Eventname => "Music";

        [JsonProperty]
        public string MusicTrack { get; internal set; }
    }
}
