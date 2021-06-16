﻿using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal;
using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Storage.Models
{
    public sealed class NavigationModel : ModelBase
    {
        private readonly Queue<NavigationPoint> _history = new Queue<NavigationPoint>();

        public NavigationModel(JournalEventService eventservice)
        {

            eventservice.Subscribe<LocationEvent>(LocationCallback);
            eventservice.Subscribe<FSDJumpEvent>(FSDJumpCallback);
            eventservice.Subscribe<StartJumpEvent>(FSDStartJumpCallback);
            eventservice.Subscribe<FSDTargetEvent>(FSDTargetCallback);
        }

        private void FSDTargetCallback(FSDTargetEvent obj)
        {
            SetValue(() => TargetSystemName, obj.Name);
            SetValue(() => RemainingJumpsInRoute, obj.RemainingJumpsInRoute);
        }

        private void FSDStartJumpCallback(StartJumpEvent obj)
        {
            if (obj.JumpType == "Hyperspace")
            {
                SetValue(() => HyperJump, true);
                SetValue(() => HyperJumpTarget, obj.StarSystem);
                SetValue(() => TargetStarClass, obj.StarClass);
            }
        }

        private void FSDJumpCallback(FSDJumpEvent obj)
        {
            SetValue(() => CurrentSystemName, obj.StarSystem);
            SetValue(() => CurrentSystemAddress, obj.SystemAddress);
            SetValue(() => HyperJump, false);
            SetValue(() => HyperJumpTarget, "");

            AddNavigationPoint(obj.Timestamp, obj.StarSystem, NavigationPointType.Hyperjump, obj.JumpDist);
        }

        private void LocationCallback(LocationEvent obj)
        {
            SetValue(() => CurrentSystemName, obj.StarSystem);
            SetValue(() => CurrentSystemAddress, obj.SystemAddress);

            AddNavigationPoint(obj.Timestamp, obj.StarSystem, NavigationPointType.Current, null);
        }

        private void AddNavigationPoint(DateTime timestamp, string starSystem, NavigationPointType current, double? jumpdistance)
        {
            var point = new NavigationPoint()
            {
                Timestamp = timestamp,
                Type = current,
                StarName = starSystem,
                JumpDistance = jumpdistance
            };

            if (_history.Count == 20)
            {
                _history.Dequeue();
            }

            _history.Enqueue(point);

            OnAction("AddNavigationPoint");
        }

        public string CurrentSystemName { get => GetValue(() => CurrentSystemName); }

        public long CurrentSystemAddress { get => GetValue(() => CurrentSystemAddress); }

        public string TargetSystemName { get => GetValue(() => TargetSystemName); }

        public int RemainingJumpsInRoute { get => GetValue(() => RemainingJumpsInRoute); }

        public bool HyperJump { get => GetValue(() => HyperJump); }

        public string HyperJumpTarget { get => GetValue(() => HyperJumpTarget); }

        public string TargetStarClass { get => GetValue(() => TargetStarClass); }

        public NavigationPoint[] NavigationHinstory { get => _history.ToArray(); }               
    }
}