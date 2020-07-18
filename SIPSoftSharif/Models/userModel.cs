using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIPSoftSharif.Models
{
    class userModel
    {
        public int UserId { get; set; }
        public int MadadkarId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool IsActive { get; set; }
        public string Birthdate { get; set; }
        public int HamiCount { get; set; }
        public string SIPUsername { get; set; }
        public string SIPPassword { get; set; }
        public string SIPServer { get; set; }
        public string SIPUri { get; set; }
        public string SIPDisplayname { get; set; }
        public List<String> Roles { get; set; }
        public ICollection<Messages> Messages { get; set; }
        public object Username { get; internal set; }
    }

    public class Messages
    {
        public int MessageId { get; set; }
        public string MessageDate { get; set; }
        public string From { get; set; }
        public string MessageBody { get; set; }

    }
}