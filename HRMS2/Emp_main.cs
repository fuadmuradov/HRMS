//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRMS2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emp_main
    {
        public int ID { get; set; }
        public string ata_adi { get; set; }
        public string Qan_qrupu { get; set; }
        public string DBT { get; set; }
        public string Din { get; set; }
        public string Gender { get; set; }
        public string aile_durumu { get; set; }
        public string milliyet { get; set; }
        public Nullable<int> Emp_number { get; set; }
        public string photo { get; set; }
    
        public virtual Emp_company Emp_company { get; set; }
    }
}