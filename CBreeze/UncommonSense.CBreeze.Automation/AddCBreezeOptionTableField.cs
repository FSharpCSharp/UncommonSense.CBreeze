﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Core;
using UncommonSense.CBreeze.Utils;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.Add, "CBreezeOptionTableField")]
    public class AddCBreezeOptionTableField : AddCBreezeTableField
    {
        [Parameter()]
        public string AltSearchField
        {
            get;
            set;
        }

        [Parameter()]
        public string AutoFormatExpr
        {
            get;
            set;
        }

        [Parameter()]
        public AutoFormatType? AutoFormatType
        {
            get;
            set;
        }

        [Parameter()]
        public BlankNumbers? BlankNumbers
        {
            get;
            set;
        }

        [Parameter()]
        public bool? BlankZero
        {
            get;
            set;
        }

        [Parameter()]
        public string CalcFormulaFieldName
        {
            get;
            set;
        }

        [Parameter()]
        public CalcFormulaMethod? CalcFormulaMethod
        {
            get;
            set;
        }

        [Parameter()]
        public SwitchParameter CalcFormulaReverseSign
        {
            get;
            set;
        }

        [Parameter()]
        public string CalcFormulaTableName
        {
            get;
            set;
        }

        [Parameter()]
        public string CaptionClass
        {
            get;
            set;
        }

        [Parameter()]
        public bool? Editable
        {
            get;
            set;
        }

        [Parameter()]
        public ExtendedDataType? ExtendedDataType
        {
            get;
            set;
        }

        [Parameter()]
        public FieldClass? FieldClass
        {
            get;
            set;
        }

        [Parameter()]
        public string InitValue
        {
            get;
            set;
        }

        [Parameter()]
        public string MaxValue
        {
            get;
            set;
        }

        [Parameter()]
        public string MinValue
        {
            get;
            set;
        }

        [Parameter()]
        public bool? NotBlank
        {
            get;
            set;
        }

        [Parameter()]
        public string OptionString
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            foreach (var table in Table)
            {
                var field = table.Fields.Add(new OptionTableField(GetNo(table), Name));

                field.Properties.AltSearchField = AltSearchField;
                field.Properties.AutoFormatExpr = AutoFormatExpr;
                field.Properties.AutoFormatType = AutoFormatType;
                field.Properties.BlankNumbers = BlankNumbers;
                field.Properties.BlankZero = BlankZero;
                field.Properties.CalcFormula.FieldName = CalcFormulaFieldName;
                field.Properties.CalcFormula.Method = CalcFormulaMethod;
                field.Properties.CalcFormula.ReverseSign = CalcFormulaReverseSign;
                field.Properties.CalcFormula.TableName = CalcFormulaTableName;
                field.Properties.CaptionClass = CaptionClass;
                field.Properties.Description = Description;
                field.Properties.Editable = Editable;
                field.Properties.ExtendedDatatype = ExtendedDataType;
                field.Properties.FieldClass = FieldClass;
                field.Properties.InitValue = InitValue;
                field.Properties.MaxValue = MaxValue;
                field.Properties.MinValue = MinValue;
                field.Properties.NotBlank = NotBlank;
                field.Properties.OptionString = OptionString;

                if (AutoCaption)
                    field.AutoCaption();

                if (PassThru)
                    WriteObject(field);
            }
        }
    }
}
