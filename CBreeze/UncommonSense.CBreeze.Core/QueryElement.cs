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
    public abstract partial class QueryElement : KeyedAndNamedItem<int>
    {
        private String name;
        private Int32? indentationLevel;

        public QueryElement(Int32 id, String name, Int32? indentationLevel)
        {
            ID = id;
            this.indentationLevel = indentationLevel;
            this.name = name;
        }

        public abstract QueryElementType Type
        {
            get;
        }

        public String Name
        {
            get
            {
                return this.name;
            }
        }

        public Int32? IndentationLevel
        {
            get
            {
                return this.indentationLevel;
            }
        }


        public override string GetName()
        {
            return Name;
        }
    }
}
