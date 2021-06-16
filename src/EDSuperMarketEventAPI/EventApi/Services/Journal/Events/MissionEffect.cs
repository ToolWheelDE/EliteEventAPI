using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
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