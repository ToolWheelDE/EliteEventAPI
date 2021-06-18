using Newtonsoft.Json;
using System.Collections.Generic;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class PowerplayVoucherEvent : EventModelBase
    {
        [JsonProperty]
        public string Power { get; internal set; }

        [JsonProperty]
        public List<string> Systems { get; internal set; }
    }
}
