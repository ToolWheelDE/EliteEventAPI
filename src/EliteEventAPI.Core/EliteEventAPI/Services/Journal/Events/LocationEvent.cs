using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class LocationEvent : EventModelBase
    {
        [JsonProperty]
        public bool Docked { get; internal set; }

        [JsonProperty]
        public bool Taxi { get; internal set; }

        [JsonProperty]
        public bool Multicrew { get; internal set; }

        [JsonProperty]
        public bool OnFoot { get; internal set; }

        [JsonProperty]
        public string StationName { get; internal set; }

        [JsonProperty]
        public string StationType { get; internal set; }

        [JsonProperty]
        public long MarketID { get; internal set; }

        [JsonProperty]
        public SystemFaction StationFaction { get; internal set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        [Obsolete]
        public double DistFromStarLS { get; internal set; }

        [JsonProperty]
        public string StationGovernment { get; internal set; }

        [JsonProperty("StationGovernment_Localised")]
        public string StationGovernmentLocalised { get; internal set; }

        [JsonProperty]
        public string StationAllegiance { get; internal set; }

        [JsonProperty]
        public List<string> StationServices { get; internal set; }

        [JsonProperty]
        public string StationEconomy { get; internal set; }

        [JsonProperty("StationEconomy_Localised")]
        public string StationEconomyLocalised { get; internal set; }

        [JsonProperty]
        public StationEconomy[] StationEconomies { get; internal set; }

        [JsonProperty]
        public string StarSystem { get; internal set; }

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public double[] StarPos { get; internal set; }

        [JsonProperty]
        public string[] Powers { get; internal set; }

        [JsonProperty]
        public string PowerplayState { get; internal set; }

        [JsonProperty]
        public Conflict[] Conflicts { get; internal set; }

        [JsonProperty]
        public string SystemAllegiance { get; internal set; }

        [JsonProperty]
        public string SystemEconomy { get; internal set; }

        [JsonProperty("SystemEconomy_Localised")]
        public string SystemEconomyLocalised { get; internal set; }

        [JsonProperty]
        public string SystemSecondEconomy { get; internal set; }

        [JsonProperty("SystemSecondEconomy_Localised")]
        public string SystemSecondEconomyLocalised { get; internal set; }

        [JsonProperty]
        public string SystemGovernment { get; internal set; }

        [JsonProperty("SystemGovernment_Localised")]
        public string SystemGovernmentLocalised { get; internal set; }

        [JsonProperty]
        public string SystemSecurity { get; internal set; }

        [JsonProperty("SystemSecurity_Localised")]
        public string SystemSecurityLocalised { get; internal set; }

        [JsonProperty]
        public long Population { get; internal set; }

        [JsonProperty]
        public string Body { get; internal set; }

        [JsonProperty]
        public long BodyId { get; internal set; }

        [JsonProperty]
        public string BodyType { get; internal set; }

        [JsonProperty]
        public Faction[] Factions { get; internal set; }

        [JsonProperty]
        public SystemFaction SystemFaction { get; internal set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public float Latitude { get; internal set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public float Longitude {get;internal set;}
    }  
}