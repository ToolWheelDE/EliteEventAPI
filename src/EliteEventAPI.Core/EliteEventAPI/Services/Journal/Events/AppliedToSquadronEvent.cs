using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class AppliedToSquadronEvent : EventModelBase
    {
        [JsonProperty]
        public string SquadronName { get; internal set; }
    }
}
