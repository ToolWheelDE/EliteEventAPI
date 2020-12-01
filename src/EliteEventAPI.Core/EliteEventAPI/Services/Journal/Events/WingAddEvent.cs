using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class WingAddEvent:EventModelBase
    {
        [JsonProperty]
        public string Name { get; internal set; }
    }
}
