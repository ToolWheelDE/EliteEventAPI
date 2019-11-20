using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class WingAddEvent:EventModelBase
    {
        [JsonProperty]
        public string Name { get; internal set; }
    }
}
