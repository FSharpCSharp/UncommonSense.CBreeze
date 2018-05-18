using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UncommonSense.CBreeze.Common;

namespace UncommonSense.CBreeze.Core
{
    public abstract class Object : KeyedItem<int>, IHasName, IHasProperties, INode
    {
        internal Object(int id, string name)
        {
            ID = id;
            Name = name;
            ObjectProperties = new ObjectProperties();
        }

        public string Name { get; set; }
        public string VariableName => Name.MakeVariableName();
        public abstract ObjectType Type { get; }
        public ObjectProperties ObjectProperties { get; protected set; }
        public override string ToString() => string.Format("{0} {1} {2}", Type, ID, Name);
        public string GetName() => Name;
        public abstract Properties AllProperties { get; }
        public abstract INode ParentNode { get; }
        public abstract IEnumerable<INode> ChildNodes { get; }
    }
}
