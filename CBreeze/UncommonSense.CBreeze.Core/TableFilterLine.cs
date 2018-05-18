using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
        public class TableFilterLine
    {
        public TableFilterLine(string fieldName, SimpleTableFilterType type, string value)
        {
            FieldName = fieldName;
            Type = type;
            Value = value;
        }

        public string FieldName
        {
            get;
            protected set;
        }

        public SimpleTableFilterType Type
        {
            get;
            protected set;
        }

        public string Value
        {
            get;
            protected set;
        }
    }
}
