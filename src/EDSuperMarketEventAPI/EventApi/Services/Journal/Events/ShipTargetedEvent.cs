using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class ShipTargetedEvent : EventModelBase
    {
        [JsonProperty]
        public bool TargetLocked { get; internal set; }

        [JsonProperty]
        public string Ship { get; internal set; }

        [JsonProperty("Ship_Localised")]
        public string ShipLocalised { get; internal set; }

        [JsonProperty]
        public long ScanStage { get; internal set; }

        [JsonProperty]
        public string PilotName { get; internal set; }

        [JsonProperty("PilotName_Localised")]
        public string PilotNameLocalised { get; internal set; }

        [JsonProperty]
        public string PilotRank { get; internal set; }

        [JsonProperty]
        public double ShieldHealth { get; internal set; }

        [JsonProperty]
        public double HullHealth { get; internal set; }

        [JsonProperty]
        public string Faction { get; internal set; }

        [JsonProperty]
        public string LegalStatus { get; internal set; }

        [JsonProperty]
        public long Bounty { get; internal set; }

        [JsonProperty]
        public string Subsystem { get; internal set; }

        [JsonProperty("Subsystem_Localised")]
        public string SubsystemLocalised { get; internal set; }

        [JsonProperty]
        public double SubsystemHealth { get; internal set; }

        [JsonProperty]
        public string Power { get; internal set; }
    }
}