using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public sealed class AtmosphereComposition
    {
        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public double Percent { get; internal set; }
    }
}