using EliteEventAPI.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services
{
    class EDSMSyncConfiguration : ConfigurationBase
    {
        public override string Section => "EDSMSync";

        public string Commandname { get; set; }

        public string APIKey { get; set; }
    }
}
