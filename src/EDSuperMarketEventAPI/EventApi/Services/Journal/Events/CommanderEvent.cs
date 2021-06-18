using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    /// <summary>
    /// Triggerd on startup
    /// </summary>
    public sealed class CommanderEvent : EventModelBase
    {
        /// <summary>
        /// Player ID
        /// </summary>
        [JsonProperty]
        public string FID { get; internal set; }

        /// <summary>
        /// Playername
        /// </summary>
        [JsonProperty]
        public string Name { get; internal set; }
    }
}
