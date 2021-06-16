using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    /// <summary>
    /// Triggerd if a new commander is created
    /// </summary>
    public sealed class NewCommanderEvent : EventModelBase
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public string Package { get; internal set; }
    }
}
