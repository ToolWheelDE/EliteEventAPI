using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class FSDJumpEvent : EventModelBase
    {
        [JsonProperty]
        public string StarSystem { get; internal set; }

        [JsonProperty]
        public string Body { get; internal set; }

        [JsonProperty]
        public string BodyID { get; internal set; }

        [JsonProperty]
        public string BodyType { get; internal set; }

        [JsonProperty]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public double[] StarPos { get; internal set; }

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
        public string[] Powers { get; internal set; }

        [JsonProperty]
        public string PowerplayState { get; internal set; }

        [JsonProperty]
        public double JumpDist { get; internal set; }

        [JsonProperty]
        public double FuelUsed { get; internal set; }

        [JsonProperty]
        public double FuelLevel { get; internal set; }

        [JsonProperty]
        public FSDFaction[] Factions { get; internal set; }

        [JsonProperty]
        public SystemFaction SystemFaction { get; internal set; }

        [JsonProperty]
        public string FactionState { get; internal set; }

        [JsonProperty]
        public int BoostUsed { get; internal set; }

        [JsonProperty]
        public SystemConflicts[] Conflicts { get; internal set; }
    }
}