﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UncommonSense.CBreeze.Common;

namespace UncommonSense.CBreeze.Parse
{
    public partial class Parser
    {
        internal void ParseReportControl(Lines lines)
        {
            var match = lines.FirstLineMustMatch(Patterns.PageControl);
            var controlID = match.Groups[1].Value.ToInteger();
            var controlType = match.Groups[2].Value.ToEnum<ClassicControlType>();
            var posX = match.Groups[3].Value.ToInteger();
            var posY = match.Groups[4].Value.ToInteger();
            var width = match.Groups[5].Value.ToInteger();
            var height = match.Groups[6].Value.ToInteger();
            var controlSeparator = match.Groups[7].Value;

            Listener.OnBeginReportControl(controlID, controlType, posX, posY, width, height);

            if (controlSeparator == ";")
            {
                var indentation = lines.First().Length - lines.First().TrimStart().Length;
                lines.Unindent(indentation);
                ParseFormControlProperties(lines);
            }

            Listener.OnEndReportControl();
        }
    }
}
