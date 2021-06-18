using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class FriendsEvent : EventModelBase
    {
        [JsonProperty]
        public string Status { get; internal set; }

        [JsonProperty]
        public string Name { get; internal set; }
    }
}
