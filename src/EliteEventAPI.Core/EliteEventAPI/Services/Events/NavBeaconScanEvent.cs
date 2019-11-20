using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class NavBeaconScanEvent : EventModelBase
    {
        protected internal override string Eventname => throw new NotImplementedException();

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public long NumBodies { get; internal set; }
    }
}
