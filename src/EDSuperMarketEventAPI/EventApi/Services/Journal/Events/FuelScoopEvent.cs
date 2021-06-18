using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class FuelScoopEvent : EventModelBase
    {
        [JsonProperty]
        public double Scooped { get; internal set; }

        [JsonProperty]
        public double Total { get; internal set; }
    }
}
