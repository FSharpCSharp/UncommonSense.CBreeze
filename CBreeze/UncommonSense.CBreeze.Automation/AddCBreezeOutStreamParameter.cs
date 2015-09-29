﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.Add, "CBreezeOutStreamParameter")]
    public class AddCBreezeOutStreamParameter : AddCBreezeParameter<OutStreamParameter>
    {
        protected override OutStreamParameter CreateParameter()
        {
            return Parameters.Add(new OutStreamParameter(Var, GetParameterID(), Name));   
        }
    }
}
