using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class AsteroidCrackedEvent : EventModelBase
    {
        [JsonProperty]
        public string Body { get; internal set; }
    }
}
