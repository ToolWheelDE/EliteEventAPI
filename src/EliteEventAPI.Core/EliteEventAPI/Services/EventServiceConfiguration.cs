using System;
using System.Collections.Generic;
using System.Text;
using EliteEventAPI.Configuration;

namespace EliteEventAPI.Services
{
    class EventServiceConfiguration : ConfigurationBase
    {
        public EventServiceConfiguration()
        {
            Exclude = new string[] { };
        }

        public override string Section => "EventService";

        public string[] Exclude { get; set; }
    }
}
