using EliteEventAPI.Services.Models.StarSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.StarSystemMap.Models
{
    public abstract class SystemNode
    {
        private long _bodyid;

        internal static SystemNode CreateNodeFromObject(SystemObject obj)
        {
            switch (obj.ObjectType)
            {
                case ObjectType.Star:
                    return new StarNode((StarObject)obj);

                case ObjectType.Planet:
                    return new PlanetNode((PlanetObject)obj);

                case ObjectType.ClusterBelt:
                    return new ClusterBeltNode((ClusterBeltObject)obj);

                case ObjectType.Ring:
                    return new RingNode((RingObject)obj);

                default:
                    throw new NotSupportedException($"Not supported: {obj.ObjectType}");
            }
        }


        public SystemNode(long bodyid)
        {
            _bodyid = bodyid;
        }

        public SystemNode(SystemObject obj)
        {
            Object = obj;
        }

        public SystemObject Object { get; internal set; }

        protected internal List<SystemNode> ParentList { get; } = new List<SystemNode>();

        protected internal List<SystemNode> ChildList { get; } = new List<SystemNode>();

        public bool IsDiscovered { get => Object != null; }

        public long BodyId { get => IsDiscovered ? Object.Id : _bodyid; internal set => _bodyid = value; }

        public bool HasParents { get => ParentList.Count > 0; }

        public override string ToString()
        {
            if (Object != null)
            {
                return $"BodyID:{BodyId} - Name:{Object.Name}";
            }
            else
            {
                return $"BodyID:{BodyId} - Type:{GetType().Name}";
            }
        }
    }

    public abstract class SystemNode<T> : SystemNode
         where T : SystemObject
    {

        public SystemNode(long bodyid) : base(bodyid)
        { }

        public SystemNode(T obj) : base(obj)
        { }

        public SystemNode[] Parents { get => ParentList.ToArray(); }

        public SystemNode[] Childs { get => ChildList.ToArray(); }

        public ObjectType ObjectType { get => Object.ObjectType; }

        public new T Object { get => (T)base.Object; internal set => base.Object = value; }
    }
}
