using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class PassengersStatistic
    {
        [JsonProperty("Passengers_Missions_Accepted", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long PassengersMissionsAccepted { get; internal set; }

        [JsonProperty("Passengers_Missions_Disgruntled", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long PassengersMissionsDisgruntled { get; internal set; }

        [JsonProperty("Passengers_Missions_Bulk", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long PassengersMissionsBulk { get; internal set; }

        [JsonProperty("Passengers_Missions_VIP", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long PassengersMissionsVip { get; internal set; }

        [JsonProperty("Passengers_Missions_Delivered", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long PassengersMissionsDelivered { get; internal set; }

        [JsonProperty("Passengers_Missions_Ejected", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long PassengersMissionsEjected { get; internal set; }
    }
}