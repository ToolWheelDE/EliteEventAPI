using System;
using EliteEventAPI.Services.Events;

namespace EliteEventAPI.Services.Models
{
    public class SystemObject
    {
        public ObjectType Type { get; private set; }

        public long Id { get; internal set; }

        public string Name { get; internal set; }

        public bool Landable { get; internal set; }

        public Parent[] Parents { get; internal set; }

        public string Scantype { get; internal set; }



        internal static StarObject CreateStar(ScanEvent obj)
        {
            return new StarObject()
            {
                Type = ObjectType.Star,
                Scantype = obj.ScanType,

                Name = obj.BodyName,
                Id = obj.BodyId,
                Parents = obj.Parents,
                Age = obj.AgeMY,

                Subclass = obj.Subclass,
                Startype = obj.StarType,
                Luminosity = obj.Luminosity,
                Landable = obj.Landable,
            };
        }

        internal static SystemObject CreatePlanet(ScanEvent obj)
        {
            return new PlanetObject()
            {
                Type = ObjectType.Planet,
                Scantype = obj.ScanType,

                Name = obj.BodyName,
                Id = obj.BodyId,
                Parents = obj.Parents,
                PlanetClass = obj.PlanetClass,
                Mass = obj.MassEm,
                Landable = obj.Landable,
                Composition = obj.Composition,
                Atmosphere = obj.Atmosphere,
                AtmosphereComposition = obj.AtmosphereComposition,
                AtmosphereType = obj.AtmosphereType
            };
        }

        internal static SystemObject CreateCluster(ScanEvent obj)
        {
            return new ClusterBeltObject()
            {
                Type = ObjectType.ClusterBelt,
                Scantype = obj.ScanType,

                Name = obj.BodyName,
                Id = obj.BodyId,
                Parents = obj.Parents,
            };
        }
    }
}