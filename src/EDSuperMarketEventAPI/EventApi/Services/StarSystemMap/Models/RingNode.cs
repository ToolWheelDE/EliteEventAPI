using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Models.StarSystem;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.StarSystemMap.Models
{
    public sealed class RingNode : SystemNode<RingObject>
    {
        public RingNode(long bodyid) : base(bodyid)
        { }

        public RingNode(RingObject obj) : base(obj)
        { }
    }
}
