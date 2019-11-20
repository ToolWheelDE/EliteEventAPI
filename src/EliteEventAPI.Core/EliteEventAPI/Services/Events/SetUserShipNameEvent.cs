using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class SetUserShipNameEvent : EventModelBase
    {
        [JsonProperty]
        public string Ship { get; internal set; }

        [JsonProperty]
        public long ShipId { get; internal set; }

        [JsonProperty]
        public string UserShipName { get; internal set; }

        [JsonProperty]
        public string UserShipId { get; internal set; }
    }
}
