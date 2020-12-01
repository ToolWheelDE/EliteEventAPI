using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class MusicEvent : EventModelBase
    {
        [JsonProperty]
        public string MusicTrack { get; internal set; }
    }
}
