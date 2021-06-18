using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class Parent
    {
        [JsonProperty]
        public long? Null { get; internal set; }

        [JsonProperty]
        public long? Star { get; internal set; }

        [JsonProperty]
        public long? Planet { get; internal set; }

        [JsonProperty]
        public long? Ring { get; internal set; }
    }
}
