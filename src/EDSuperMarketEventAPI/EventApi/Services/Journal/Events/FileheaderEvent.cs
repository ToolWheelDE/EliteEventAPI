using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    /// <summary>
    /// Is triggered on application start.
    /// </summary>
    public class FileheaderEvent : EventModelBase
    {
        /// <summary>
        /// Number of File
        /// </summary>
        /// <remarks>If the play session goes on a long time, and the journal gets very large, the file will be closed and a new file started with an increased part number: the heading entry is added at the beginning of every file. See also the "Continued" event</remarks>
        [JsonProperty]
        public int Part { get; internal set; }

        /// <summary>
        /// Game Language
        /// </summary>
        [JsonProperty]
        public string Language { get; internal set; }

        /// <summary>
        /// Game Version
        /// </summary>
        [JsonProperty]
        public string Gameversion { get; internal set; }

        /// <summary>
        /// Game Build Version
        /// </summary>
        [JsonProperty]
        public string Build { get; internal set; }
    }
}
