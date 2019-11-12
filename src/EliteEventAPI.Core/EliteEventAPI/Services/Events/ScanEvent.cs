using Newtonsoft.Json;

namespace EliteEventAPI.Services.Events
{
    public sealed class ScanEvent : EventModelBase
    {
        protected internal override string Eventname => "Scan";

        [JsonProperty]
        public string StarSystem { get; internal set; }

        [JsonProperty]
        public string SystemAddress { get; internal set; }

        [JsonProperty]
        public string StarType { get; internal set; }

        [JsonProperty]
        public string Subclass { get; internal set; }

        [JsonProperty]
        public string ScanType { get; internal set; }

        [JsonProperty]
        public string BodyName { get; internal set; }

        [JsonProperty]
        public long BodyId { get; internal set; }

        [JsonProperty]
        public Parent[] Parents { get; internal set; }

        [JsonProperty]
        public bool TidalLock { get; internal set; }

        [JsonProperty]
        public string TerraformState { get; internal set; }

        [JsonProperty]
        public string PlanetClass { get; internal set; }

        [JsonProperty]
        public string Atmosphere { get; internal set; }

        [JsonProperty]
        public string AtmosphereType { get; internal set; }

        [JsonProperty]
        public string Volcanism { get; internal set; }

        [JsonProperty]
        public double MassEm { get; internal set; }

        [JsonProperty]
        public double DistanceFromArrivalLS { get; internal set; }

        [JsonProperty]
        public double AbsoluteMagnitude { get; internal set; }

        [JsonProperty("Age_MY")]
        public double AgeMY { get; internal set; }

        [JsonProperty]
        public string Luminosity { get; internal set; }

        [JsonProperty]
        public bool WasDiscovered { get; internal set; }

        [JsonProperty]
        public bool WasMapped { get; internal set; }

        [JsonProperty]
        public double StellarMass { get; internal set; }

        [JsonProperty]
        public double Radius { get; internal set; }

        [JsonProperty]
        public double SurfaceGravity { get; internal set; }

        [JsonProperty]
        public double SurfaceTemperature { get; internal set; }

        [JsonProperty]
        public double SurfacePressure { get; internal set; }

        [JsonProperty]
        public bool Landable { get; internal set; }

        [JsonProperty]
        public Material[] Materials { get; internal set; }

        [JsonProperty]
        public Composition Composition { get; internal set; }

        [JsonProperty]
        public AtmosphereComposition[] AtmosphereComposition { get; internal set; }

        [JsonProperty]
        public double SemiMajorAxis { get; internal set; }

        [JsonProperty]
        public double Eccentricity { get; internal set; }

        [JsonProperty]
        public double OrbitalInclination { get; internal set; }

        [JsonProperty]
        public double Periapsis { get; internal set; }

        [JsonProperty]
        public double OrbitalPeriod { get; internal set; }

        [JsonProperty]
        public double RotationPeriod { get; internal set; }

        [JsonProperty]
        public double AxialTilt { get; internal set; }

        [JsonProperty]
        public Ring[] Rings { get; internal set; }

        [JsonProperty]
        public string ReserveLevel { get; internal set; }
    }
}
