﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UncommonSense.CBreeze.ObjectModelBuilder
{
    public class Attribute 
    {
        public Attribute(string typeName, string name)
        {
            TypeName = typeName;
            Name = name;
        }

        public string Name
        {
            get;
            internal set;
        }

        public string TypeName
        {
            get;
            internal set;
        }

        public ObjectModelElement Type
        {
            get
            {
                return Item.ObjectModel.Elements.FirstOrDefault(e => e.Name == TypeName);
            }
        }

        public Item Item
        {
            get;
            internal set;
        }
    }
}