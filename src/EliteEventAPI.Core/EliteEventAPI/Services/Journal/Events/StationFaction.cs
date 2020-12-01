using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteEventAPI.Services.Journal.Events
{
    public class StationFaction
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public string FactionState { get; internal set; }
    }
}
