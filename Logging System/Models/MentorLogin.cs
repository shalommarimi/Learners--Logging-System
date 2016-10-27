using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logging_System.Models
{
    public class MentorLogin
    {
        public int MentorID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}