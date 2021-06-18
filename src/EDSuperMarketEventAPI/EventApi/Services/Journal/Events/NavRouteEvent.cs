using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class NavRouteEvent : EventModelBase
    {
        protected internal override string Eventname => "*NavRoute";

        [JsonProperty]
        public Route[] Route { get; internal set; }
    }
}
