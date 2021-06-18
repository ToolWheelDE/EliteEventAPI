using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class ChangeCrewRoleEvent : EventModelBase
    {
        [JsonProperty]
        public string Role { get; internal set; }
    }
}
