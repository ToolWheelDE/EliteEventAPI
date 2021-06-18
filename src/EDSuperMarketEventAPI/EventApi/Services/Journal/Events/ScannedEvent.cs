using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class ScannedEvent : EventModelBase
    {
        [JsonProperty("ScanType")]
        public string ScanType { get; internal set; }
    }
}
