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
	public abstract partial class ReportElement : KeyedItem<int>, IHasName, IHasProperties
	{
		private Int32? indentationLevel;
		private String name;

		public ReportElement(Int32 id, Int32? indentationLevel)
		{
			ID = id;
			this.indentationLevel = indentationLevel;
		}

		public abstract ReportElementType Type
		{
			get;
		}

		public Int32? IndentationLevel
		{
			get
			{
				return this.indentationLevel;
			}
		}

		public String Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		public abstract Properties AllProperties
		{
			get;
		}

		public  string GetName()
		{
			return Name;
		}
	}
}
