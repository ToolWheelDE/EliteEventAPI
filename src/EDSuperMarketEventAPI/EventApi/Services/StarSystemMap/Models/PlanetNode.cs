using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Models.StarSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.StarSystemMap.Models
{
    public sealed class PlanetNode : SystemNode<PlanetObject>
    {
        public PlanetNode(long bodyid) : base(bodyid)
        { }

        public PlanetNode(PlanetObject obj) : base(obj)
        { }
    }
}
