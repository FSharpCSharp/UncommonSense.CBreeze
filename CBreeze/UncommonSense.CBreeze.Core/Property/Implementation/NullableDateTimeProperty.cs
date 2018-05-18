using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
        public class NullableDateTimeProperty : NullableValueProperty<DateTime>
    {
        internal NullableDateTimeProperty(string name)
            : base(name)
        {
        }
    }
}