using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class MiningStatistic
    {
        [JsonProperty("Mining_Profits", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long MiningProfits { get; internal set; }

        [JsonProperty("Quantity_Mined", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long QuantityMined { get; internal set; }

        [JsonProperty("Materials_Collected", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public long MaterialsCollected { get; internal set; }
    }
}