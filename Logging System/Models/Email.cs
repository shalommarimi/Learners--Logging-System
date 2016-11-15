using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Logging_System.Models
{
    public class Email
    {
        [Required(ErrorMessage = "To field is required")]
        [Display (Name = "Recipient")]
        public string Sendto { get; set; }

        [Required(ErrorMessage = "From field is required")]
        [Display(Name = "Sender")]
        public string SentFrom { get; set; }

        [Required(ErrorMessage = "Subject field is required")]
        [Display(Name = "Email Subject")]

        public string Subject { get; set; }

        [Required(ErrorMessage = "Message field is required")]
        [Display(Name = "Actal Message")]
        public string Message { get; set; }



    }

}