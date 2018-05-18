using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UncommonSense.CBreeze.Common;

namespace UncommonSense.CBreeze.Core
{
    public class CodeTableField : TableField
    {
        public CodeTableField(string name, int dataLength = 10) : this(0, name, dataLength)
        {
        }

        public CodeTableField(int no, string name, int dataLength = 10)
            : base(no, name)
        {
            DataLength = dataLength;
            Properties = new CodeTableFieldProperties(this);
        }

        public override Properties AllProperties
        {
            get
            {
                return Properties;
            }
        }

        public override IEnumerable<INode> ChildNodes
        {
            get
            {
                yield return Properties;
            }
        }

        public int DataLength
        {
            get;
            protected set;
        }

        public CodeTableFieldProperties Properties
        {
            get;
            protected set;
        }

        public override TableFieldType Type
        {
            get
            {
                return TableFieldType.Code;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}[{1}]", base.ToString(), DataLength);
        }
    }
}