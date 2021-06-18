using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class UnderAttackEvent : EventModelBase
    {
        [JsonProperty]
        public string Target { get; internal set; }
    }
}
