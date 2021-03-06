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
    
    public partial class DoctorAvailableTime
    {
        public DoctorAvailableTime()
        {
            this.DoctorAppointments = new HashSet<DoctorAppointment>();
        }
    
        public int Id { get; set; }
        public int DoctorAvailableDateId { get; set; }
        public System.TimeSpan AvailableFrom { get; set; }
        public System.TimeSpan AvailableUntil { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual DoctorAvailableDate DoctorAvailableDate { get; set; }
        public virtual ICollection<DoctorAppointment> DoctorAppointments { get; set; }
    }
}
