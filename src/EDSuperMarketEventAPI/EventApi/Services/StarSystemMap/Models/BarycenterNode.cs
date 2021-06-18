using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Models.StarSystem;

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
