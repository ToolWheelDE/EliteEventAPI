using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class CrewLaunchFighterEvent : EventModelBase
    {
        [JsonProperty]
        public string Crew { get; internal set; }
    }
}
