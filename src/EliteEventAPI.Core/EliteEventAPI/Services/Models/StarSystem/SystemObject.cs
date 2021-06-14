using System;
using System.Diagnostics;
using System.Linq;
using EliteEventAPI.Services.Journal.Events;
using EliteEventAPI.Services.Storage.Models;

namespace EliteEventAPI.Services.Models.StarSystem
{
    public class SystemObject
    {
        public ObjectType ObjectType { get; private set; }

        public long Id { get; internal set; }

        public string Name { get; internal set; }

        public bool Landable { get; internal set; }

        public Parent[] Parents { get; internal set; }

        public string Scantype { get; internal set; }

        internal static ObjectType GetObjectType(ScanEvent obj)
        {
            if (!string.IsNullOrEmpty(obj.StarType))
            {
                return ObjectType.Star;
            }
            else if (!string.IsNullOrEmpty(obj.PlanetClass))
            {
                return ObjectType.Planet;
            }
            else if (obj.Parents.Sum(m => m.Ring) > 0)
            {
                return ObjectType.ClusterBelt;
            }
            else if (string.IsNullOrEmpty(obj.PlanetClass) || string.IsNullOrEmpty(obj.StarType))
            {
                return ObjectType.Ring;
            }
            else
            {
                Debug.WriteLine("Unkown Scan objecttype");
                return 0;
            }
        }

        internal static SystemObject GetObject(ScanEvent obj)
        {
            switch (GetObjectType(obj))
            {
                case ObjectType.Star:
                    return CreateStar(obj);

                case ObjectType.Planet:
                    return CreatePlanet(obj);

                case ObjectType.ClusterBelt:
                    return CreateCluster(obj);

                case ObjectType.Ring:
                    return CreateRing(obj);

                default:
                    return null;
            }
        }

        internal static StarObject CreateStar(ScanEvent obj)
        {
            return new StarObject()
            {
                ObjectType = ObjectType.Star,
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

        internal static PlanetObject CreatePlanet(ScanEvent obj)
        {
            return new PlanetObject()
            {
                ObjectType = ObjectType.Planet,
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

        internal static ClusterBeltObject CreateCluster(ScanEvent obj)
        {
            return new ClusterBeltObject()
            {
                ObjectType = ObjectType.ClusterBelt,
                Scantype = obj.ScanType,

                Name = obj.BodyName,
                Id = obj.BodyId,
                Parents = obj.Parents,
            };
        }

        internal static RingObject CreateRing(ScanEvent obj)
        {
            return new RingObject()
            {
                ObjectType = ObjectType.Ring,
                Scantype = obj.ScanType,

                Name = obj.BodyName,
                Id = obj.BodyId,
                Parents = obj.Parents,
            };
        }
    }
}