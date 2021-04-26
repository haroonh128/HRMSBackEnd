using System;
using System.Collections.Generic;
using System.Text;

namespace Helper.ViewModels
{
    public class Branches
    {
        public string acCode { get; set; }
        public string acName { get; set; }
    }

    public class cashInhandClass {
        public string acCode { get; set; }
        public string acName { get; set; }
        public string ExportCode { get; set; }

    }

    public class pettyCashClass
    {
        public string acCode { get; set; }
        public string acName { get; set; }
        public string ExportCode { get; set; }
        public string AccntntCod { get; set; }

    }

    public class salaryCashClass
    {
        public string acCode { get; set; }
        public string acName { get; set; }
        public string ExportCode { get; set; }
    }

    public class advanceClass
    {
        public string acCode { get; set; }
        public string acName { get; set; }
        public string ExportCode { get; set; }

    }

    public class bankClass
    {
        public string acCode { get; set; }
        public string acName { get; set; }
        public string ExportCode { get; set; }

    }

    public class reqObj
    {
        public string brnchId { get; set; }
        public string name { get; set; }
        public string advDD { get; set; }
        public string loadGrdDD { get; set; }
        public string cshInhndDD { get; set; }
        public string pettyDD { get; set; }
        public string salDD { get; set; }
        public string baDD { get; set; }
    }

}
