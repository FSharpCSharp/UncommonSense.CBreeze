﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBreeze.NextGen
{
	public class BigIntegerParameter : Parameter
	{
		public BigIntegerParameter(int uid, string name)
			: base(uid, name)
		{
		}

		public override ParameterType Type
		{
			get
			{
				return ParameterType.BigInteger;
			}
		}
	}
}