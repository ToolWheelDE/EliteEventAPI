using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class FighterRebuiltEvent : EventModelBase
    {
        [JsonProperty]
        public string Loadout { get; internal set; }
    }
}
