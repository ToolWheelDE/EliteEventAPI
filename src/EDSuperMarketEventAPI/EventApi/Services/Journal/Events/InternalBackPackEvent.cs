﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    internal sealed class InternalBackPackEvent : EventModelBase
    {
        protected internal override string Eventname => "BackPack";
    }
}
