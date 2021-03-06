﻿using System.Drawing;

namespace UncommonSense.CBreeze.Core.Property.Implementation
{
    public class ColorProperty : ValueProperty<Color>
    {
        public ColorProperty(string name) : base(name)
        {
        }

        public override bool HasValue => Value != Color.FromArgb(100, 100, 100);
        public override void Reset()
        {
            Value = Color.FromArgb(100, 100, 100);
        }
    }
}