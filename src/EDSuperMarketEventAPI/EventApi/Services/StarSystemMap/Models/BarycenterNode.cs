using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Models.StarSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.StarSystemMap.Models
{
    public sealed class BarycenterNode : SystemNode<BarycenterObject>
    {
        public BarycenterNode(long bodyid) : base(bodyid)
        {

        }

        public BarycenterNode(BarycenterObject obj) : base(obj)
        { }
    }
}
