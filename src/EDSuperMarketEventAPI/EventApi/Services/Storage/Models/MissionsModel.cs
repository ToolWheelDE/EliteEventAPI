using System;
using System.Collections.Generic;
using System.Linq;
using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal;
using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Storage.Models
{
    public sealed class MissionsModel : ModelBase
    {
        private readonly List<Mission> _missions = new List<Mission>();

        public MissionsModel(JournalEventService eventservice)
        {
            eventservice.Subscribe<MissionAbandonedEvent>(MissionAbandonedCallback);
            eventservice.Subscribe<MissionAcceptedEvent>(MissionAcceptedCallback);
            eventservice.Subscribe<MissionCompletedEvent>(MissionCompletedCallback);
            eventservice.Subscribe<MissionFailedEvent>(MissionFailedCallback);
            eventservice.Subscribe<MissionsEvent>(MissionsCallback);
        }

        private void MissionAbandonedCallback(MissionAbandonedEvent obj)
        {

        }

        private void MissionFailedCallback(MissionFailedEvent obj)
        {

        }

        private void MissionCompletedCallback(MissionCompletedEvent obj)
        {
            var mission = _missions.Where(m => m.MissionID == obj.MissionId).FirstOrDefault();

            _missions.Remove(mission);
            OnAction("MissionComplete");
        }

        private void MissionAcceptedCallback(MissionAcceptedEvent obj)
        {

        }

        private void MissionsCallback(MissionsEvent obj)
        {
            foreach (var item in obj.Active)
            {
                var mission = new Mission()
                {
                    Status = MissionStatus.Active,
                    MissionID = item.MissionId,
                    TypeString = item.Name,
                    PassengerMission = item.PassengerMission,
                    ExpireDate = DateTime.Now.AddSeconds(item.Expires)
                };

                _missions.Add(mission);
                OnAction("MissionAdd");
            }

            foreach (var item in obj.Failed)
            {
                var mission = new Mission()
                {
                    Status = MissionStatus.Failed,
                    MissionID = item.MissionId,
                    TypeString = item.Name,
                    PassengerMission = item.PassengerMission,
                    ExpireDate = DateTime.Now.AddSeconds(item.Expires)
                };

                _missions.Add(mission);
                OnAction("MissionAdd");
            }

            foreach (var item in obj.Complete)
            {
                var mission = new Mission()
                {
                    Status = MissionStatus.Complet,
                    MissionID = item.MissionId,
                    TypeString = item.Name,
                    PassengerMission = item.PassengerMission,
                    ExpireDate = DateTime.Now.AddSeconds(item.Expires)
                };

                _missions.Add(mission);
                OnAction("AddMission");
            }
        }
    }
}