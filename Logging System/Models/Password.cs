using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Logging_System.Models
{
    public class Password
    {

        [Required]
        [EmailAddress]
        public string Username { get; set; }


        [Required (ErrorMessage ="This field is required")]
        [MaxLength(10)]
        [MinLength(6)]
        [Display(Name = "Old Password")]
        public string OldPassword { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [MaxLength(10)]
        [MinLength(6)]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(10)]
        [MinLength(6)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("NewPassword", ErrorMessage = "The Password and Confirmation Password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}