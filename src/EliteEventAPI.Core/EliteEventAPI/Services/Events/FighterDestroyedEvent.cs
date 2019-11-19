using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class FighterDestroyedEvent : EventModelBase
    {
        protected internal override string Eventname => "FighterDestroyed";
    }
}
