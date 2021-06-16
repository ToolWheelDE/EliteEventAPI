using System;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Storage.Models
{
    public class Mission
    {
        public object Status { get; internal set; }

        public long MissionID { get; internal set; }

        public string TypeString { get; internal set; }

        public bool PassengerMission { get; internal set; }

        public DateTime ExpireDate { get; internal set; }
    }
}