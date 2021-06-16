using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Models.StarSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.StarSystemMap.Models
{
    public sealed class StarNode : SystemNode<StarObject>
    {
        public StarNode(long bodyid) : base(bodyid)
        { }

        public StarNode(StarObject obj) : base(obj)
        { }
    }
}
