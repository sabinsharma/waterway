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
    
    public partial class Doctor
    {
        public Doctor()
        {
            this.DoctorAvailableDates = new HashSet<DoctorAvailableDate>();
            this.Reviews = new HashSet<Review>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public string Gender { get; set; }
        public string Language { get; set; }
        public int YearOfExperience { get; set; }
        public string Text { get; set; }
        public byte[] Photo { get; set; }
        public Nullable<System.DateTime> EnteredDate { get; set; }
        public Nullable<int> EnteredBy { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Member Member { get; set; }
        public virtual ICollection<DoctorAvailableDate> DoctorAvailableDates { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
