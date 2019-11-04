using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class MissionEffect
    {
        [JsonProperty]
        public string Effect { get; internal set; }

        [JsonProperty("Effect_Localised")]
        public string EffectLocalised { get; internal set; }

        [JsonProperty]
        public string Trend { get; internal set; }
    }
}