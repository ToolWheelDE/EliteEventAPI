using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    internal sealed class InternalBackPackEvent : EventModelBase
    {
        protected internal override string Eventname => "BackPack";
    }
}
