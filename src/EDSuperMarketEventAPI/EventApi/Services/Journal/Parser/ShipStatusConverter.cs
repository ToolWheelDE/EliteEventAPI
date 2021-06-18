using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Parser
{
    static class ShipStatusConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MissingMemberHandling = MissingMemberHandling.Ignore,
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
