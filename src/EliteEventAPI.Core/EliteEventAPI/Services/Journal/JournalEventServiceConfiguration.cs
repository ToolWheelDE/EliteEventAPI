using System;
using System.Collections.Generic;
using System.Text;
using EliteEventAPI.Configuration;

namespace EliteEventAPI.Services.Journal
{
    class JournalEventServiceConfiguration : ConfigurationBase
    {
        public JournalEventServiceConfiguration()
        {
            Exclude = new string[] { };
        }

        public override string Section => "JournalEventService";

        public string[] Exclude { get; set; }
    }
}
