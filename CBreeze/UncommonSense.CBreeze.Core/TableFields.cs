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
    public class TableFields : IntegerKeyedAndNamedContainer<TableField>
    {
        internal TableFields()
        {
        }

        public override void ValidateName(TableField item)
        {
            TestNameNotNullOrEmpty(item);
            TestNameUnique(item);
        }
    }
}