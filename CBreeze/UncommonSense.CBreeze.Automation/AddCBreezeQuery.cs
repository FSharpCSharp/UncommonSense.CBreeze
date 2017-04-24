﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Common;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.Add, "CBreezeQuery", DefaultParameterSetName = NewWithoutID)]
    [OutputType(typeof(Query))]
    public class AddCBreezeQuery : NewCBreezeObject
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true, ParameterSetName = AddWithID)]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ParameterSetName = AddWithoutID)]
        public Application Application { get; set; }

        [Parameter()]
        public string Description
        {
            get; set;
        }

        [Parameter(ParameterSetName = AddWithID)]
        [Parameter(ParameterSetName = AddWithoutID)]
        public SwitchParameter PassThru { get; set; } = true;

        [Parameter()]
        public ReadState? ReadState
        {
            get; set;
        }

        [Parameter()]
        [ValidateRange(0, int.MaxValue)]
        public int? TopNoOfRows
        {
            get; set;
        }

        protected Query CreateQuery()
        {
            var query = new Query(ID, Name);
            SetObjectProperties(query);

            query.Properties.Description = Description;
            query.Properties.ReadState = ReadState;
            query.Properties.TopNumberOfRows = TopNoOfRows;

            if (AutoCaption)
                query.AutoCaption();

            if (SubObjects != null)
            {
                var subObjects = SubObjects.Invoke().Select(o => o.BaseObject);
                query.Properties.OrderBy.AddRange(subObjects.OfType<QueryOrderByLine>());
                query.Elements.AddRange(subObjects.OfType<QueryElement>());
                query.Code.Functions.AddRange(subObjects.OfType<Function>());
                query.Code.Variables.AddRange(subObjects.OfType<Variable>());
                query.Code.Events.AddRange(subObjects.OfType<Event>());
            }

            return query;
        }

        protected override void ProcessRecord()
        {
            switch (ParameterSetName)
            {
                case NewWithID:
                case NewWithoutID:
                    WriteObject(CreateQuery());
                    break;

                case AddWithID:
                case AddWithoutID:
                    Application.Queries.Add(CreateQuery()).DoIf(PassThru, q => WriteObject(q));
                    break;
            }
        }
    }
}