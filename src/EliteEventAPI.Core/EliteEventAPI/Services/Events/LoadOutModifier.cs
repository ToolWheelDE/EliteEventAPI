using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public class LoadOutModifier
    {
        [JsonProperty]
        public string Label { get; internal set; }

        [JsonProperty]
        public double Value { get; internal set; }

        [JsonProperty]
        public double OriginalValue { get; internal set; }

        [JsonProperty]
        public long LessIsGood { get; internal set; }
    }
}