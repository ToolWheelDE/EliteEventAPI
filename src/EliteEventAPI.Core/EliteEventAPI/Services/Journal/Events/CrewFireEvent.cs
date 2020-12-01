using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class CrewFireEvent : EventModelBase
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public long CrewId { get; internal set; }
    }
}
