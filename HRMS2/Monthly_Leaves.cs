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
    
    public partial class Monthly_Leaves
    {
        public int ID { get; set; }
        public Nullable<int> gun_sayi { get; set; }
        public string ay { get; set; }
        public Nullable<int> il { get; set; }
        public string sebeb { get; set; }
        public Nullable<int> Emp_id { get; set; }
    
        public virtual Emp_company Emp_company { get; set; }
    }
}