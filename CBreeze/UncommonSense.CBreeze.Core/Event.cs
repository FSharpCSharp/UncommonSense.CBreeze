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
    public partial class Event : IHasParameters, IHasVariables
    {
        public Event(int sourceID, string sourceName, int id, string name)
        {
            ID = id;
            Name = name;
            SourceID = sourceID;
            SourceName = sourceName;
            CodeLines = new CodeLines();
            Parameters = new Parameters();
            Variables = new Variables(this);
        }

        public int SourceID
        {
            get;
            protected set;
        }

        public string SourceName
        {
            get;
            protected set;
        }

        public int ID
        {
            get;
            protected set;
        }

        public string Name
        {
            get;
            protected set;
        }

        public CodeLines CodeLines
        {
            get;
            protected set;
        }

        public Parameters Parameters
        {
            get;
            protected set;
        }

        public Variables Variables
        {
            get;
            protected set;
        }

    }
}
