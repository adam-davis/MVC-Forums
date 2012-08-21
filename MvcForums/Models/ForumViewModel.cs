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

    public class ForumViewModel
    {
        [Required(ErrorMessage = "Forum name required.")]
        [DisplayName("Forum Name")]
        [StringLength(120, ErrorMessage="Name must be between 1 and 120 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description Required.")]
        [DisplayName("Forum Description")]
        [StringLength(500, ErrorMessage="Descriptions must be between 1 and 500 characters in length.")]
        public string Description { get; set; }

    }
}