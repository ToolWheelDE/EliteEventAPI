using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteEventAPI.Services.Events
{
    public class HeatWarningEvent : EventModelBase
    {
        public override string Eventname => "HeatWarning";
   }
}
