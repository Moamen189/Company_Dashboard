﻿using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Invailed Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [MinLength(5, ErrorMessage = "Minimum Length is 5")]

        public string Password { get; set; }

       

        public bool RememberMe { get; set; }
    }
}
