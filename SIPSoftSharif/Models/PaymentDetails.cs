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
    
    public partial class PaymentDetails
    {
        public int id { get; set; }
        public Nullable<int> PaymentId { get; set; }
        public string UniqueId { get; set; }
        public Nullable<int> MadadjouId { get; set; }
        public string MadadjouName { get; set; }
        public Nullable<int> DonationAmount { get; set; }
        public Nullable<int> OptionalDonation { get; set; }
        public string OptionalDescription { get; set; }
    
        public virtual PayRequests PayRequests { get; set; }
    }
}
