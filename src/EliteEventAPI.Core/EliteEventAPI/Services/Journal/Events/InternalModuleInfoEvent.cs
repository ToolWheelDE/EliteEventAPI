using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    internal sealed class InternalModuleInfoEvent : EventModelBase
    {
        protected internal override string Eventname => "ModuleInfo";
    }
}
