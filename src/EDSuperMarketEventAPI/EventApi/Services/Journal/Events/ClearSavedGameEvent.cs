using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    /// <summary>
    /// Is triggerd if you reset the game
    /// </summary>
    public class ClearSavedGameEvent : EventModelBase
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
