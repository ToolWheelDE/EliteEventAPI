using System;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Storage.Models
{
    internal class ChatMessage
    {
        public ChatChannel Channel { get; internal set; }

        public string Message { get; internal set; }

        public string From { get; internal set; }
        public DateTime Time { get; internal set; }
    }
}