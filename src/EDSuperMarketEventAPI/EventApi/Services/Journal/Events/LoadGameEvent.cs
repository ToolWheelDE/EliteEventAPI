using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    /// <summary>
    /// Triggerd on startup
    /// </summary>
    public sealed class LoadGameEvent : EventModelBase
    {
        [JsonProperty]
        public string Fid { get; internal set; }

        [JsonProperty]
        public string Commander { get; internal set; }

        [JsonProperty]
        public string Ship { get; internal set; }

        [JsonProperty("Ship_Localised")]
        public string ShipLocalised { get; internal set; }

        [JsonProperty]
        public long ShipId { get; internal set; }

        [JsonProperty]
        public string ShipName { get; internal set; }

        [JsonProperty]
        public string ShipIdent { get; internal set; }

        [JsonProperty]
        public double FuelLevel { get; internal set; }

        [JsonProperty]
        public double FuelCapacity { get; internal set; }

        [JsonProperty]
        public string StartLanded { get; internal set; }

        [JsonProperty]
        public string GameMode { get; internal set; }

        [JsonProperty]
        public string Group { get; internal set; }

        [JsonProperty]
        public long Credits { get; internal set; }

        [JsonProperty]
        public long Loan { get; internal set; }
    }
}
