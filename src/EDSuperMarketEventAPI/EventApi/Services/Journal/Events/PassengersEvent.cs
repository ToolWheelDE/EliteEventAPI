using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    /// <summary>
    /// Triggerd on startup
    /// </summary>
    public sealed class PassengersEvent : EventModelBase
    {
        [JsonProperty]
        public Manifest[] Manifest { get; internal set; }
    }
}
