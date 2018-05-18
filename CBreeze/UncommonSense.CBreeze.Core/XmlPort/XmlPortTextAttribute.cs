using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UncommonSense.CBreeze.Common;

namespace UncommonSense.CBreeze.Core
{
    public class XmlPortTextAttribute : XmlPortNode
    {
        public XmlPortTextAttribute(string nodeName, int? indentationLevel = null, Guid id = new Guid())
            : base(nodeName, indentationLevel, id)
        {
            Properties = new XmlPortTextAttributeProperties(this);
        }

        public override XmlPortNodeType NodeType => XmlPortNodeType.Attribute;
        public override XmlPortSourceType SourceType => XmlPortSourceType.Text;

        public override IEnumerable<INode> ChildNodes
        {
            get
            {
                yield return Properties;
            }
        }

        public override XmlPortNodeAndSourceType Type
        {
            get
            {
                return XmlPortNodeAndSourceType.XmlPortTextAttribute;
            }
        }

        public XmlPortTextAttributeProperties Properties
        {
            get;
            protected set;
        }

        public override Properties AllProperties
        {
            get
            {
                return Properties;
            }
        }
    }
}