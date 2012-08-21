using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcForums.Models
{
    //ViewModel class used for validation of User for use in
    //forms in views
    
    public class UserValidationModel
    {
        [Required(ErrorMessage="User name required.")]
        [RegularExpression("[a-zA-Z-_]{4,12}", ErrorMessage="12 characters max. Please only use letters, numbers, and _ -")]
        [DisplayName("User name")]
        public string UserName{ get; set; }

        [Required(ErrorMessage="Password required.")]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage="Please type password again")]
        [DisplayName("Password (again)")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage="Passwords don't match - try again")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage="E-mail address is required.")]
        [RegularExpression(@"^([\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+\.)*[\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+@((((([a-zA-Z0-9]{1}[a-zA-Z0-9\-]{0,62}[a-zA-Z0-9]{1})|[a-zA-Z])\.)+[a-zA-Z]{2,6})|(\d{1,3}\.){3}\d{1,3}(\:\d{1,5})?)$", ErrorMessage = "Not a valid email.")]

        public string Email { get; set; } 

    }
}