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
    
    public partial class City
    {
        public City()
        {
            this.Donations = new HashSet<Donation>();
            this.PaymentInfoes = new HashSet<PaymentInfo>();
            this.VolunteerInfoes = new HashSet<VolunteerInfo>();
        }
    
        public int Id { get; set; }
        public string CityName { get; set; }
    
        public virtual ICollection<Donation> Donations { get; set; }
        public virtual ICollection<PaymentInfo> PaymentInfoes { get; set; }
        public virtual ICollection<VolunteerInfo> VolunteerInfoes { get; set; }
    }
}
