//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIPSoftSharif.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobShift
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JobShift()
        {
            this.ShiftPersons = new HashSet<ShiftPersons>();
        }
    
        public int id { get; set; }
        public Nullable<int> JobId { get; set; }
        public Nullable<System.TimeSpan> ShiftStartTime { get; set; }
        public Nullable<System.TimeSpan> ShiftEndTime { get; set; }
        public Nullable<int> ShiftQuantity { get; set; }
        public Nullable<int> ShiftValue { get; set; }
        public Nullable<bool> deleted { get; set; }
    
        public virtual JobSchedule JobSchedule { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShiftPersons> ShiftPersons { get; set; }
    }
}
