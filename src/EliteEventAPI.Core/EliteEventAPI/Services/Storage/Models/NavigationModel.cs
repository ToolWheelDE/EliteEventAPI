using EliteEventAPI.Services.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Storage.Models
{
    public sealed class NavigationModel : ModelBase
    {
        public NavigationModel(EventService eventservice)
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

        }

        private void FSDJumpCallback(FSDJumpEvent obj)
        {
            SetValue(() => SystemName, obj.Body);
        }

        private void LocationCallback(LocationEvent obj)
        {
            SetValue(() => SystemName, obj.Body);
        }

        public string SystemName { get => GetValue(() => SystemName); }

        public string TargetSystemName { get => GetValue(() => TargetSystemName); }

        public int RemainingJumpsInRoute { get => GetValue(() => RemainingJumpsInRoute); }
    }
}