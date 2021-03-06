﻿using UncommonSense.CBreeze.Core.Form.Contracts;
using UncommonSense.CBreeze.Core.Property.Implementation;

namespace UncommonSense.CBreeze.Core.Form.Control.Properties
{
    public abstract class CaptionBaseProperties : FormControlProperties, ICaption
    {
        private readonly StringProperty _captionClass = new StringProperty("CaptionClass");
        private readonly MultiLanguageProperty _captionMl = new MultiLanguageProperty("CaptionML");

        protected CaptionBaseProperties(FormControl control) : base(control)
        {
        }

        public MultiLanguageValue CaptionMl => _captionMl.Value;

        public string CaptionClass
        {
            get => _captionClass.Value;
            set => _captionClass.Value = value;
        }
    }
}