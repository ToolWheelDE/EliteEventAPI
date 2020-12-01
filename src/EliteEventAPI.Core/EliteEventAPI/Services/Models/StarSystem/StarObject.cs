using EliteEventAPI.Services.Journal.Events;

namespace EliteEventAPI.Services.Models.StarSystem
{
    public sealed class StarObject : SystemObject
    {
        internal StarObject()
        { }

        public double Age { get; internal set; }

        public string Subclass { get; internal set; }

        public string Startype { get; internal set; }

        public string Luminosity { get; internal set; }
        
    }
}