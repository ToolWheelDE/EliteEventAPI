using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Core.Events
{
    public sealed class ShutdownEvent : EventModelBase
    {
        public override string Eventname => "Shutdown";
    }
}
