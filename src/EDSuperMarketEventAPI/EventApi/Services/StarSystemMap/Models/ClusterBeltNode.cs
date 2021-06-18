using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Models.StarSystem;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.StarSystemMap.Models
{
    public sealed class ClusterBeltNode : SystemNode<ClusterBeltObject>
    {
        public ClusterBeltNode(long bodyid) : base(bodyid)
        { }

        public ClusterBeltNode(ClusterBeltObject obj) : base(obj)
        { }
    }
}
