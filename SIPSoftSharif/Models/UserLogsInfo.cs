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
    
    public partial class UserLogsInfo
    {
        public int UserLogId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> ProgramId { get; set; }
        public Nullable<int> ObjectId { get; set; }
        public Nullable<int> TableId { get; set; }
        public Nullable<int> TableField { get; set; }
        public Nullable<int> LogTypeId { get; set; }
        public string LogNote { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public Nullable<int> WebLogId { get; set; }
        public string LogTypeName { get; set; }
        public string TableName { get; set; }
        public string TableTitle { get; set; }
    }
}
