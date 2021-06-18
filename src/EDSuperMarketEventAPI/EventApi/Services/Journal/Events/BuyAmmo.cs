using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class BuyAmmo : EventModelBase
    {
        [JsonProperty]
        public int Cost { get; internal set; }
    }
}
