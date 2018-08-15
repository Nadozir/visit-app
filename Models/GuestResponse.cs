using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VisitorsInvites.Models {
    public class GuestResponse {
        [Required(ErrorMessage = "Please enter your name")]
            // Enter your name.
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
            // Enter a valid email address.
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
            // Enter your phone number.
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll attend")]
            // Specify whether you'll attend.
        public bool? WillAttend { get; set; }
    }
}