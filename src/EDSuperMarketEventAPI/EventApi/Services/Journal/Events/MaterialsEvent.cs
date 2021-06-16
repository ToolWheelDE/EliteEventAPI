using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    /// <summary>
    /// Triggerd on startup
    /// </summary>
    public sealed class MaterialsEvent : EventModelBase
    {
        [JsonProperty]
        public RawModel[] Raw { get; internal set; }

        [JsonProperty]
        public EncodedModel[] Manufactured { get; internal set; }

        [JsonProperty]
        public EncodedModel[] Encoded { get; internal set; }
    }
}
