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
    
    public partial class UsersInfo
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public byte[] UserPass { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<int> UserModel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool UserActive { get; set; }
        public string UserNote { get; set; }
        public string UserEmail { get; set; }
        public Nullable<bool> UserConfirm { get; set; }
        public string UserImg { get; set; }
        public string UserMobile { get; set; }
        public string SecurityCode { get; set; }
        public Nullable<System.DateTime> UpdatePass { get; set; }
        public Nullable<int> LoginCount { get; set; }
        public Nullable<System.DateTime> LoginDate { get; set; }
        public string LoginAddress { get; set; }
        public Nullable<int> LoginStatus { get; set; }
        public Nullable<int> LoginMax { get; set; }
        public Nullable<bool> UserOnline { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public Nullable<bool> UserConfirmMobile { get; set; }
        public Nullable<bool> UserConfirmEmail { get; set; }
        public Nullable<int> UserZone { get; set; }
        public Nullable<int> UserDateType { get; set; }
        public string UserCountry { get; set; }
        public string UserCurrency { get; set; }
        public string UserMobileCode { get; set; }
        public string UserLanguage { get; set; }
        public Nullable<int> ProgramDefault { get; set; }
        public Nullable<int> UserProgram { get; set; }
        public string ParentName { get; set; }
    }
}
