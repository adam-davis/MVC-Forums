using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcForums.Models
{
    //ViewModel class used for validation of User for use in
    //forms in views
    [PropertiesMustMatch("Password", "ConfirmPassword", ErrorMessage="Passwords don't match - try again")]
    public class UserValidationModel
    {
        [Required(ErrorMessage="User name required.")]
        [RegularExpression("[a-zA-Z-_]{4,12}", ErrorMessage="12 characters max. Please only use letters, numbers, and _ -")]
        [DisplayName("User name")]
        public string UserName{ get; set; }

        [Required(ErrorMessage="Password required.")]
        [DisplayName("Password")]   
        [PasswordPropertyText(true)]
        public string Password { get; set; }

        [Required(ErrorMessage="Please type password again")]
        [DisplayName("Password (again)")]
        [PasswordPropertyText(true)]
        public string ConfirmPassword { get; set; }

    }
}