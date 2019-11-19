using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class DisbandedSquadronEvent : EventModelBase
    {
        protected internal override string Eventname => "DisbandedSquadron";

        [JsonProperty]
        public string SquadronName { get; internal set; }
    }
}
