using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class FSDActiveState
    {
        [JsonProperty]
        public string State { get; internal set; }
    }
}