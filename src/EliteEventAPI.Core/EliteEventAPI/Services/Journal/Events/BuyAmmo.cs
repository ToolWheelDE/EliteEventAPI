using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class BuyAmmo : EventModelBase
    {
        [JsonProperty]
        public int Cost { get; internal set; }
    }
}
