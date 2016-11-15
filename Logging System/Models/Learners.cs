using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Logging_System.Models
{
    public class Learners
    {

       

        [Required]
        public string Names { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]

        public string Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DOB { get; set; }

        [Required]
        [MaxLength(13)]
        [MinLength(13)]
        public string RSAID { get; set; }

        [Required]

        public string Learnership { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        [Phone]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string Mobile { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(6)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The Password and Confirmation Password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public bool IsUserActive { get; set; }

  


        SqlConnection con = new SqlConnection("Data Source=DVTLSMASHINI;Initial Catalog=DVTLearnership;User ID=sa;Password=Lulama.01");
        SqlCommand cmd = new SqlCommand();

        public string InsertRegDetails(Learners _lean)
        {
            cmd.CommandText = "Insert into [Learners_Information] values('" + _lean.Names 
                + "','" + _lean.Surname 
                + "','" + _lean.Gender 
                + "','" + _lean.DOB 
                + "','" + _lean.RSAID
                + "','" + _lean.Learnership
                + "','" + _lean.Mobile 
                + "','" + _lean.Email 
                + "','" + _lean.Username 
                + "','" + _lean.Password 
                + "','" + _lean.IsUserActive + "')";

            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "Successfully Registered " + _lean.Names + " " + _lean.Surname;
            }
            catch (Exception es)
            {
                throw es;
            }
        }
    }

}
