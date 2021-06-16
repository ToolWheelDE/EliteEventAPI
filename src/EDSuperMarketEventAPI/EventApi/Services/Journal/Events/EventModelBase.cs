using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public abstract class EventModelBase
    {
        public EventModelBase()
        {
            Eventname = GetType().Name.Replace("Event", "");
        }

        protected internal virtual string Eventname { get; private set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; internal set; }

        [JsonProperty("event")]
        public string Event { get; internal set; }

        [JsonProperty("odyssey", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool? Odyssey { get; internal set; }

        [JsonProperty("horizons", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool? Horizons { get; internal set; }
    }
}
