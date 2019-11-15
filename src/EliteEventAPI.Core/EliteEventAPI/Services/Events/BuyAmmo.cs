using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class BuyAmmo : EventModelBase
    {
        protected internal override string Eventname => "BuyAmmo";

        [JsonProperty]
        public int Cost { get; internal set; }
    }
}
