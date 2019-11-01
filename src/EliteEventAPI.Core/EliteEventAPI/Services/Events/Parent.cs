using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class Parent
    {
        [JsonProperty]
        public long Null { get; internal set; }
    }
}
