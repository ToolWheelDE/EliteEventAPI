using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class AsteroidCrackedEvent : EventModelBase
    {
        [JsonProperty]
        public string Body { get; internal set; }
    }
}
