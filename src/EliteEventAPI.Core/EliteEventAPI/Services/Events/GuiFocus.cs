using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public enum GuiFocus : int
    {
        NoFocus,
        InternalPanel,
        ExternalPanel,
        CommsPanel,
        RolePanel,
        StationServices,
        GalaxyMap,
        SystemMap,
        Orrery,
        FSS,
        SAA,
        Codex
    }
}
