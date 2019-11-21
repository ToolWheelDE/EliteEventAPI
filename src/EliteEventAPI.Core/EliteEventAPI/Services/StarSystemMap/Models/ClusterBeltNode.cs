using EliteEventAPI.Services.Models.StarSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.StarSystemMap.Models
{
    public sealed class ClusterBeltNode : SystemNode<ClusterBeltObject>
    {
        public ClusterBeltNode(long bodyid) : base(bodyid)
        { }

        public ClusterBeltNode(ClusterBeltObject obj) : base(obj)
        { }
    }
}
