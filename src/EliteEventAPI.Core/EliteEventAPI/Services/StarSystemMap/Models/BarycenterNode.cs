using EliteEventAPI.Services.Models.StarSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.StarSystemMap.Models
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
