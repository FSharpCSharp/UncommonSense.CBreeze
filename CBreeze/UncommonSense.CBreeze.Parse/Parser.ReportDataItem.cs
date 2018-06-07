﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UncommonSense.CBreeze.Common;

namespace UncommonSense.CBreeze.Parse
{
    public partial class Parser
    {
        internal void ParseReportDataItem(Lines lines, ObjectType objectType)
        {
            lines.FirstLineMustMatch(Patterns.BeginSection);
            lines.LastLineMustMatch(Patterns.EndDataItem);
			lines.Unindent(2);

            Listener.OnBeginReportDataItem();

            foreach (var chunk in lines.Chunks(Patterns.SectionSignature))
            {
                ParseSection(chunk, objectType);
            }

            Listener.OnEndReportDataItem();
        }
    }
}
