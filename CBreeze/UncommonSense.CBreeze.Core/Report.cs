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
    public partial class Report : Object
    {
        private Code code = new Code();
        private ReportElements elements = new ReportElements();
        private ReportLabels labels = new ReportLabels();
        private ReportProperties properties = new ReportProperties();
        private RdlData rdlData = new RdlData();
#if NAV2015
        private WordLayout wordLayout = new WordLayout();
#endif
        private ReportRequestPage requestPage = new ReportRequestPage();

        public Report(Int32 id, String name) : base(id, name)
        {
        }

        public override ObjectType Type
        {
            get
            {
                return ObjectType.Report;
            }
        }

        public Code Code
        {
            get
            {
                return this.code;
            }
        }

        public ReportElements Elements
        {
            get
            {
                return this.elements;
            }
        }

        public ReportLabels Labels
        {
            get
            {
                return this.labels;
            }
        }

        public ReportProperties Properties
        {
            get
            {
                return this.properties;
            }
        }

        public RdlData RdlData
        {
            get
            {
                return this.rdlData;
            }
        }

#if NAV2015
        public WordLayout WordLayout
        {
            get
            {
                return this.wordLayout;
            }
        }
#endif

        public ReportRequestPage RequestPage
        {
            get
            {
                return this.requestPage;
            }
        }

        public override Properties AllProperties
        {
            get
            {
                return Properties;
            }
        }
    }
}
