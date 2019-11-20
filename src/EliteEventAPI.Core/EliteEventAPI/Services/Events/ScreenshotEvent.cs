using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class ScreenshotEvent : EventModelBase
    {
        [JsonProperty]
        public string Filename { get; internal set; }

        [JsonProperty]
        public long Width { get; internal set; }

        [JsonProperty]
        public long Height { get; internal set; }

        [JsonProperty]
        public string System { get; internal set; }

        [JsonProperty]
        public string Body { get; internal set; }

        [JsonProperty]
        public double Latitude { get; internal set; }

        [JsonProperty]
        public double Longitude { get; internal set; }

        [JsonProperty]
        public long Heading { get; internal set; }

        [JsonProperty]
        public double Altitude { get; internal set; }
    }
}
