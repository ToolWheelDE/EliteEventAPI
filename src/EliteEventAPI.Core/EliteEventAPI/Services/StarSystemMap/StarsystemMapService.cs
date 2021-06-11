using EliteEventAPI.Services;
using EliteEventAPI.Services.Journal;
using EliteEventAPI.Services.Journal.Events;
using EliteEventAPI.Services.Models.StarSystem;
using EliteEventAPI.Services.StarSystemMap.Models;
using EliteEventAPI.Services.Storage.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace EliteEventAPI.Services.StarsystemMap
{
    public delegate void UpdateStarsystemMapDelegate(SystemNode node);

    public sealed class StarsystemMapService : ServiceBase
    {
        public event UpdateStarsystemMapDelegate UpdateStarsystemMap;

        private readonly List<SystemNode> _nodes = new List<SystemNode>();

        public StarsystemMapService()
        {
            var events = ServiceController.GetService<JournalEventService>();

            events.Subscribe<ScanEvent>(ScanCallback);
            events.Subscribe<FSDJumpEvent>(FSDJumpCallback);
        }

        private void FSDJumpCallback(FSDJumpEvent obj)
        {
            _nodes.Clear();
            UpdateStarsystemMap?.Invoke(null);
        }

        public override string Name => "Starsystem map";

        private void ScanCallback(ScanEvent obj)
        {
            var systemobject = SystemObject.GetObject(obj);

            switch (systemobject.ObjectType)
            {
                case ObjectType.Star:
                    HandleStarObject((StarObject)systemobject);
                    break;

                case ObjectType.Planet:
                    HandlePlanetObject((PlanetObject)systemobject);
                    break;

                case ObjectType.ClusterBelt:
                    HandleClusterBeltObject((ClusterBeltObject)systemobject);
                    break;

                case ObjectType.Ring:
                    HandleRingObject((RingObject)systemobject);
                    break;

                default:
                    break;
            }
        }

        public IEnumerable<SystemNode> GetAllNodes()
        {
            return _nodes.ToArray();
        }

        public IEnumerable<SystemNode> GetRootElements()
        {
            return _nodes.Where(m => !m.HasParents);
        }

        public IEnumerable<SystemNode> GetChildNodes(SystemNode item)
        {
            return item.ChildList;
        }

        private void HandleRingObject(RingObject obj)
        {
            CheckDiscovere(obj);
            CheckNodeObjects(obj);
        }

        private void HandleClusterBeltObject(ClusterBeltObject obj)
        {
            CheckDiscovere(obj);
            CheckNodeObjects(obj);
        }

        private void HandlePlanetObject(PlanetObject obj)
        {
            CheckDiscovere(obj);
            CheckNodeObjects(obj);
        }

        private void HandleStarObject(StarObject obj)
        {
            CheckDiscovere(obj);
            CheckNodeObjects(obj);
        }

        private void CheckDiscovere(SystemObject obj)
        {
            var origin = _nodes.Where(m => m.BodyId == obj.Id).FirstOrDefault();

            if (origin != null)
            {
                origin.Object = obj;
            }
            else
            {
                var childnode = SystemNode.CreateNodeFromObject(obj);
                _nodes.Add(childnode);
            }
        }

        private void CheckNodeObjects(SystemObject obj)
        {
            var currentParent = ExtractParents(obj);

            if (currentParent.Ring.HasValue)
            {
                var parentnode = _nodes.Where(m => m.BodyId == currentParent.Ring).FirstOrDefault();
                var childnode = _nodes.Where(m => m.BodyId == obj.Id).FirstOrDefault();

                if (parentnode == null)
                {
                    parentnode = new RingNode(currentParent.Ring.Value);
                    _nodes.Add(parentnode);
                }

                if (childnode == null)
                {
                    childnode = SystemNode.CreateNodeFromObject(obj);
                    _nodes.Add(childnode);
                }

                parentnode.ChildList.Add(childnode);
                childnode.ParentList.Add(parentnode);

                UpdateStarsystemMap?.Invoke(childnode);

                return;
            }

            if (currentParent.Planet.HasValue)
            {
                var parentnode = _nodes.Where(m => m.BodyId == currentParent.Planet).FirstOrDefault();
                var childnode = _nodes.Where(m => m.BodyId == obj.Id).FirstOrDefault();

                if (parentnode == null)
                {
                    parentnode = new PlanetNode(currentParent.Planet.Value);
                    _nodes.Add(parentnode);
                }

                if (childnode == null)
                {
                    childnode = SystemNode.CreateNodeFromObject(obj);
                    _nodes.Add(childnode);
                }

                parentnode.ChildList.Add(childnode);
                childnode.ParentList.Add(parentnode);

                UpdateStarsystemMap?.Invoke(childnode);

                return;
            }

            if (currentParent.Star.HasValue)
            {
                var parentnode = _nodes.Where(m => m.BodyId == currentParent.Star).FirstOrDefault();
                var childnode = _nodes.Where(m => m.BodyId == obj.Id).FirstOrDefault();

                if (parentnode == null)
                {
                    parentnode = new StarNode(currentParent.Star.Value);
                    _nodes.Add(parentnode);
                }

                if (childnode == null)
                {
                    childnode = SystemNode.CreateNodeFromObject(obj);
                    _nodes.Add(childnode);
                }


                parentnode.ChildList.Add(childnode);
                childnode.ParentList.Add(parentnode);

                UpdateStarsystemMap?.Invoke(childnode);

                return;
            }

            if (currentParent.Null.HasValue)
            {
                var parentnode = _nodes.Where(m => m.BodyId == currentParent.Null).FirstOrDefault();
                var childnode = _nodes.Where(m => m.BodyId == obj.Id).FirstOrDefault();

                if (parentnode == null)
                {
                    parentnode = new BarycenterNode(currentParent.Null.Value);
                    _nodes.Add(parentnode);
                }

                if (childnode == null)
                {
                    childnode = SystemNode.CreateNodeFromObject(obj);
                    _nodes.Add(childnode);
                }

                parentnode.ChildList.Add(childnode);
                childnode.ParentList.Add(parentnode);

                UpdateStarsystemMap?.Invoke(childnode);

                return;
            }
        }

        private Parent ExtractParents(SystemObject obj)
        {
            var result = new Parent();

            if (obj.Parents != null)
            {
                foreach (var item in obj.Parents)
                {
                    if (!result.Null.HasValue && item.Null.HasValue) result.Null = item.Null;
                    if (!result.Star.HasValue && item.Star.HasValue) result.Star = item.Star;
                    if (!result.Planet.HasValue && item.Planet.HasValue) result.Planet = item.Planet;
                    if (!result.Ring.HasValue && item.Ring.HasValue) result.Ring = item.Ring;
                }
            }

            return result;
        }
    }
}