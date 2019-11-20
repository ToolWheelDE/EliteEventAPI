using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class JoinedSquadronEvent : EventModelBase
    {
        protected internal override string Eventname => "JoinedSquadron";

        [JsonProperty]
        public string SquadronName { get; internal set; }
    }
}
