using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DapperMVC.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employee Id")]
        [Range(100000, 999999, ErrorMessage = "You need to enter a valud EmployeeId")]
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You need to give your first name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You need to give your last name")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "You need to give your email address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("EmailAddress", ErrorMessage = "Emails are not equals")]
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage = "You must have a passowrd")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "You need to provide a long enuaght password")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords are not equals")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}