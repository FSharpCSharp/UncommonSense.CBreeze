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
    public partial class PageActionGroup : PageActionBase
    {
        private PageActionGroupProperties properties = new PageActionGroupProperties();

        public PageActionGroup(Int32 id, Int32? indentationLevel) : base(id, indentationLevel)
        {
        }

        public override PageActionBaseType Type
        {
            get
            {
                return PageActionBaseType.PageActionGroup;
            }
        }

        public PageActionGroupProperties Properties
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