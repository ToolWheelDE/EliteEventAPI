using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class ShutdownEvent : EventModelBase
    {
        protected internal override string Eventname => "Shutdown";
    }
}
