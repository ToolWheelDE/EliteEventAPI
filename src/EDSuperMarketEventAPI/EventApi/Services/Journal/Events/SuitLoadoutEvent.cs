using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class SuitLoadoutEvent : EventModelBase
    {
        [JsonProperty]
        public long SuitID { get; internal set; }

        [JsonProperty]
        public string SuitName { get; internal set; }

        [JsonProperty]
        public string SuitName_Localised { get; internal set; }

        [JsonProperty]
        public long LoadoutID { get; internal set; }

        [JsonProperty]
        public string LoadoutName { get; internal set; }

        [JsonProperty]
        public SuitModule[] Modules { get; internal set; }
    }
}
