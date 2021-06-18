using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class ModuleInfoEvent : EventModelBase
    {
        protected internal override string Eventname => "*ModuleInfo";

        [JsonProperty]
        public ModuleSlot[] Modules { get; internal set; }
    }
}
