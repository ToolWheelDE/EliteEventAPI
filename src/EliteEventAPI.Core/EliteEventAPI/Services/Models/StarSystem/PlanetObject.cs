using EliteEventAPI.Services.Journal.Events;

namespace EliteEventAPI.Services.Models.StarSystem
{
    public sealed class PlanetObject : SystemObject
    {
        public string PlanetClass { get; internal set; }

        public double Mass { get; internal set; }

        public Composition Composition { get; internal set; }

        public string Atmosphere { get; internal set; }

        public AtmosphereComposition[] AtmosphereComposition { get; internal set; }

        public string AtmosphereType { get; internal set; }
    }
}