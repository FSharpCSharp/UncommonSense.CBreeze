﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace UncommonSense.CBreeze.Automation
{
    public abstract class NewItemCmdlet<TItem, TInputObject> : CBreezeCmdlet
    {
        protected virtual void AddItemToInputObject(TItem item, TInputObject inputObject)
        {
            var inputObjectTypeName = inputObject is PSObject ? (inputObject as PSObject).BaseObject.GetType().Name : inputObject.GetType().Name;

            throw new ApplicationException($"Don't know how to add this {item.GetType().Name} to this {inputObjectTypeName}.");
        }

        protected abstract IEnumerable<TItem> CreateItems();

        protected override void ProcessRecord()
        {
            foreach (var item in CreateItems())
            {
                if (ParameterSetNames.IsAdd(ParameterSetName))
                {
                    AddItemToInputObject(item, InputObject);
                }

                if (ParameterSetNames.IsNew(ParameterSetName) || PassThru)
                {
                    WriteObject(item);
                }
            }
        }

        [Parameter(Mandatory = true, ValueFromPipeline = true, ParameterSetName = ParameterSetNames.AddWithoutID)]
        public virtual TInputObject InputObject { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.AddWithoutID)]
        public virtual SwitchParameter PassThru { get; set; }
    }
}