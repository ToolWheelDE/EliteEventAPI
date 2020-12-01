using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    /// <summary>
    /// Triggerd on startup
    /// </summary>
    public sealed class CommanderEvent : EventModelBase
    {
        /// <summary>
        /// Player ID
        /// </summary>
        [JsonProperty]
        public string FID { get; internal set; }

        /// <summary>
        /// Playername
        /// </summary>
        [JsonProperty]
        public string Name { get; internal set; }
    }
}
