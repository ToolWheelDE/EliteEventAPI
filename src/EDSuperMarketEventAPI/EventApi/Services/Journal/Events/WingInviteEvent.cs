using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class WingInviteEvent : EventModelBase
    {
        [JsonProperty]
        public string Name { get; internal set; }
    }
}
