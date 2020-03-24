using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Feedbacksystem.Models
{
    public class AdminLog
    {
        public int Id { get; set; }
        public string Admin { get; set; }
        public string Password { get; set; }
    }
}