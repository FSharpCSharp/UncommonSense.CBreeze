using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UncommonSense.CBreeze.Common;

namespace UncommonSense.CBreeze.Core
{
    public class ByteVariable : Variable, IHasDimensions
    {
        public ByteVariable(string name) : this(0, name)
        {
        }

        public ByteVariable(int id, string name)
            : base(id, name)
        {
        }

        public string Dimensions
        {
            get;
            set;
        }

        public override VariableType Type
        {
            get
            {
                return VariableType.Byte;
            }
        }
    }
}