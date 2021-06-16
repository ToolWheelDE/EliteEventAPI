using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class BackPackItem
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long OwnerID { get; internal set; }

        [JsonProperty]
        public long MissionID { get; internal set; }

        [JsonProperty]
        public int Count { get; internal set; }
    }
}
