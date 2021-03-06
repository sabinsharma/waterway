//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLINDRIVER_TEAM4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Department
    {
        public Department()
        {
            this.Doctors = new HashSet<Doctor>();
            this.FAQs = new HashSet<FAQ>();
        }
    
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public Nullable<int> EnteredBy { get; set; }
        public Nullable<System.DateTime> EnteredDate { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual ICollection<Doctor> Doctors { get; set; }
        public virtual ICollection<FAQ> FAQs { get; set; }
    }
}
