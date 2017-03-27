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
    
    public partial class Facility
    {
        public int Id { get; set; }
        public string FacilityName { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public byte[] Photo { get; set; }
        public Nullable<int> UnitNumber { get; set; }
        public System.DateTime EnteredDate { get; set; }
        public Nullable<int> EnteredBy { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual Member Member { get; set; }
    }
}
