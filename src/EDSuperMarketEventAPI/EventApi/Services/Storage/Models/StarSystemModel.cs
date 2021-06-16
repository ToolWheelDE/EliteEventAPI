using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal;
using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events;
using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Models.StarSystem;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Storage.Models
{
    public sealed class StarSystemModel : ModelBase
    {
        private readonly List<SystemObject> _objects = new List<SystemObject>();
        private readonly List<SignalObject> _singals = new List<SignalObject>();

        public StarSystemModel(JournalEventService eventservice)
        {
            eventservice.Subscribe<FSDJumpEvent>(FSDJumpCallback);
            eventservice.Subscribe<FSSDiscoveryScanEvent>(FSSDiscoveryScanCallback);
            eventservice.Subscribe<FSSSignalDiscoveredEvent>(FSSSignalDiscoveryCallback);
            eventservice.Subscribe<FSSAllBodiesFoundEvent>(FSSAllBodiesFoundCallback);
            eventservice.Subscribe<ScanEvent>(FSSScanCallback);
        }

        private void FSDJumpCallback(FSDJumpEvent obj)
        {
            _objects.Clear();
            _singals.Clear();
            OnAction("ClearObjects");
            OnAction("ClearSignal");
        }

        private void FSSAllBodiesFoundCallback(FSSAllBodiesFoundEvent obj)
        { }

        private void FSSSignalDiscoveryCallback(FSSSignalDiscoveredEvent obj)
        {
            var signal = new SignalObject()
            {
                Name = string.IsNullOrEmpty(obj.SignalNameLocalised) ? obj.SignalName : obj.SignalNameLocalised,
                IsStation = obj.IsStation
            };

            _singals.Add(signal);
            OnAction("AddSignal");
        }

        private void FSSScanCallback(ScanEvent obj)
        {
            var systemobject = SystemObject.GetObject(obj);

            _objects.Add(systemobject);

            SetValue(() => CurrentBodySingals, _objects.Where(m => m.ObjectType == ObjectType.Star || m.ObjectType == ObjectType.Planet).Count());
            SetValue(() => CurrentNonBodySingals, _objects.Where(m => m.ObjectType == ObjectType.ClusterBelt).Count());
            OnAction("AddObject");
        }

        private void FSSDiscoveryScanCallback(FSSDiscoveryScanEvent obj)
        {
            SetValue(() => TotalBodySingals, obj.BodyCount);
            SetValue(() => TotalNonBodySingals, obj.NonBodyCount);
        }

        public int TotalBodySingals { get => GetValue(() => TotalBodySingals); }

        public int TotalNonBodySingals { get => GetValue(() => TotalNonBodySingals); }

        public int CurrentBodySingals { get => GetValue(() => CurrentBodySingals); }

        public int CurrentNonBodySingals { get => GetValue(() => CurrentNonBodySingals); }

        public SystemObject[] SystemObjects { get => _objects.ToArray(); }

        public SignalObject[] SystemSignals { get => _singals.ToArray(); }
    }
}