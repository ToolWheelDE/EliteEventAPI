using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Models.StarSystem;

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
