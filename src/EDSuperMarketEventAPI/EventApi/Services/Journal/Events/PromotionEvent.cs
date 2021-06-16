using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class PromotionEvent : EventModelBase
    {
        [JsonProperty]
        public int? Combat { get; internal set; }

        [JsonProperty]
        public int? Trade { get; internal set; }

        [JsonProperty]
        public int? Explore { get; internal set; }

        [JsonProperty]
        public int? CQC { get; internal set; }

        [JsonProperty]
        public int? Federation { get; internal set; }

        [JsonProperty]
        public int? Empire { get; internal set; }
    }
}
