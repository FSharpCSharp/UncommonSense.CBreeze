﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UncommonSense.CBreeze.ObjectModelBuilder
{
    public abstract class ObjectModelElement : ObjectModelNode
    {
        public ObjectModelElement(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
            internal set;
        }

        public ObjectModel ObjectModel
        {
            get
            {
                return (ParentNode as ObjectModel);
            }
        }
    }
}
