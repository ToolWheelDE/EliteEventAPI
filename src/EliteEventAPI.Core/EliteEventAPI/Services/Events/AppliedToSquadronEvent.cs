using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class AppliedToSquadronEvent : EventModelBase
    {
        protected internal override string Eventname => "AppliedToSquadron";

        [JsonProperty]
        public string SquadronName { get; internal set; }
    }
}
