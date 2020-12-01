using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class InternalNavRouteEvent : EventModelBase
    {
        protected internal override string Eventname => "NavRoute";
  }
}
