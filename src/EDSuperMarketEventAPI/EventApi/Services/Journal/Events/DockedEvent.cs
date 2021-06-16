using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class DockedEvent : EventModelBase
    {
        [JsonProperty]
        public bool Taxi { get; internal set; }

        [JsonProperty]
        public bool Multicrew { get; internal set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Body { get; internal set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BodyType { get; internal set; }

        [JsonProperty]
        public string StationName { get; internal set; }

        [JsonProperty]
        public string StationType { get; internal set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StationState { get; internal set; }

        [JsonProperty]
        public string StarSystem { get; internal set; }

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double[] StarPos { get; internal set; }

        [JsonProperty]
        public long MarketId { get; internal set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public Faction[] Factions { get; internal set; }

        [JsonProperty]
        public StationFaction StationFaction { get; internal set; }

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
        public double DistFromStarLs { get; internal set; }

        [JsonProperty]
        public bool Wanted { get; internal set; }

        [JsonProperty]
        public long ActiveFine { get; internal set; }
    }
}
