using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class ModuleInfoEvent : EventModelBase
    {
        protected internal override string Eventname => "ModuleInfo";

        // This is only the Information that the moduleinfo.json file is updated
    }
}
