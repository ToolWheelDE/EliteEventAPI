using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteEventAPI.Services.Events
{
    public class FileheaderEvent : EventModelBase
    {
        public override string Eventname => "Fileheader";

        [JsonProperty("")]
        public int Part { get; internal set; }

        [JsonProperty("")]
        public string Language { get; internal set; }

        [JsonProperty("")]
        public string Gameversion { get; internal set; }

        [JsonProperty("")]
        public string Build { get; internal set; }
    }
}
