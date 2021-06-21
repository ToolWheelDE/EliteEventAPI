using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class ExplorationStatistic
    {
        [JsonProperty("Systems_Visited", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SystemsVisited { get; internal set; }

        [JsonProperty("Exploration_Profits", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long ExplorationProfits { get; internal set; }

        [JsonProperty("Planets_Scanned_To_Level_2", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long PlanetsScannedToLevel2 { get; internal set; }

        [JsonProperty("Planets_Scanned_To_Level_3", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long Planets_ScannedToLevel3 { get; internal set; }

        [JsonProperty("Efficient_Scans", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long EfficientScans { get; internal set; }

        [JsonProperty("Highest_Payout", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long HighestPayout { get; internal set; }

        [JsonProperty("Total_Hyperspace_Distance", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long TotalHyperspaceDistance { get; internal set; }

        [JsonProperty("Total_Hyperspace_Jumps", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long TotalHyperspaceJumps { get; internal set; }

        [JsonProperty("Greatest_Distance_From_Start", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long GreatestDistanceFromStart { get; internal set; }

        [JsonProperty("Time_Played", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long TimePlayed { get; internal set; }

        [JsonProperty("Shuttle_Journeys", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long ShuttleJourneys { get; internal set; }

        [JsonProperty("Shuttle_Distance_Travelled", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long ShuttleDistanceTravelled { get; internal set; }

        [JsonProperty("Spent_On_Shuttles", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SpentOnShuttles { get; internal set; }

        [JsonProperty("First_Footfalls", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long FirstFootfalls { get; internal set; }

        [JsonProperty("Settlements_Visited", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long SettlementsVisited { get; internal set; }
    }
}