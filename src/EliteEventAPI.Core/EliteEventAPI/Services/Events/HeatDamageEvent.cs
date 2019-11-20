using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class HeatDamageEvent : EventModelBase
    {
        protected internal override string Eventname => "HeatDamage";
    }
}
