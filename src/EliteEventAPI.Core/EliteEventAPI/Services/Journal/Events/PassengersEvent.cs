using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    /// <summary>
    /// Triggerd on startup
    /// </summary>
    public sealed class PassengersEvent : EventModelBase
    {
        [JsonProperty]
        public Manifest[] Manifest { get; internal set; }
    }
}
