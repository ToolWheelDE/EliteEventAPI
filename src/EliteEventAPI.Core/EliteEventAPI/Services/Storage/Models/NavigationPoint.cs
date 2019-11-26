using System;

namespace EliteEventAPI.Services.Storage.Models
{
    public sealed class NavigationPoint
    {
        public DateTime Timestamp { get; internal set; }

        public NavigationPointType Type { get; internal set; }

        public string StarName { get; internal set; }

        public double? JumpDistance { get; internal set; }
    }
}