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
    
    public partial class VisitingSchedule
    {
        public int Id { get; set; }
        public int PatientVisitingHourId { get; set; }
        public int PatientId { get; set; }
        public System.TimeSpan BookedFrom { get; set; }
        public System.TimeSpan BookedTo { get; set; }
        public System.DateTime AppointmentDate { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual PatientVisitingHour PatientVisitingHour { get; set; }
    }
}
