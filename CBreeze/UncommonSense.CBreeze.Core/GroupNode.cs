// --------------------------------------------------------------------------------
// <auto-generated>
//      This code was generated by a tool.
//
//      Changes to this file may cause incorrect behaviour and will be lost if
//      the code is regenerated.
// </auto-generated>
// --------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class GroupNode : MenuSuiteNode
    {
        private MenuSuiteGroupNodeProperties properties = new MenuSuiteGroupNodeProperties();

        public GroupNode(Guid id) : base(id)
        {
        }

        public override MenuSuiteNodeType Type
        {
            get
            {
                return MenuSuiteNodeType.GroupNode;
            }
        }

        public MenuSuiteGroupNodeProperties Properties
        {
            get
            {
                return this.properties;
            }
        }


        public override string GetName()
        {
            return Properties.Name;
        }
    }
}
