using EliteEventAPI.Services.Models.StarSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.StarSystemMap.Models
{
    public sealed class StarNode : SystemNode<StarObject>
    {
        public StarNode(long bodyid) : base(bodyid)
        { }

        public StarNode(StarObject obj) : base(obj)
        { }
    }
}
