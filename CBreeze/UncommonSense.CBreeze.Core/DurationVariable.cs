using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UncommonSense.CBreeze.Common;

namespace UncommonSense.CBreeze.Core
{
    public class DurationVariable : Variable,IHasDimensions
    {
        public DurationVariable(string name) : this(0, name)
        {
        }

        public DurationVariable(int id, string name)
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
                return VariableType.Duration;
            }
        }
    }
}