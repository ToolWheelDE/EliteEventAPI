using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class SuitModule
    {
        [JsonProperty]
        public string SlotName { get; internal set; }

        [JsonProperty]
        public long SuitModuleID { get; internal set; }

        [JsonProperty]
        public string ModuleName { get; internal set; }

        [JsonProperty]
        public string ModuleName_Localised { get; internal set; }
    }
}