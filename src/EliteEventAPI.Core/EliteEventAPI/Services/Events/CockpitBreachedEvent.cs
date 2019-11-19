using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class CockpitBreachedEvent : EventModelBase
    {
        protected internal override string Eventname => "CockpitBreached";
    }
}
