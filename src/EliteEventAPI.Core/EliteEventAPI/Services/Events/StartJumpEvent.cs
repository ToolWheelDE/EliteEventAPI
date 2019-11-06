using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteEventAPI.Services.Events
{
    public class StartJumpEvent : EventModelBase
    {
        public override string Eventname => "StartJump";

        [JsonProperty]
        public string JumpType { get; internal set; }

        [JsonProperty]
        public string StarSystem { get; internal set; }

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public string StarClass { get; internal set; }
    }
}
