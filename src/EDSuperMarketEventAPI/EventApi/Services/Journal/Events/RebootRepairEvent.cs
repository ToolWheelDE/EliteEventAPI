using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class RebootRepairEvent : EventModelBase
    {
        [JsonProperty]
        public string[] Modules { get; internal set; }
    }
}
