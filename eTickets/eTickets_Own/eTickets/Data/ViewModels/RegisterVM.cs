﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required.")]
        public string FullName { get; set; }
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email address is required.")]
        public string EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Confirm password")]
        [Required(ErrorMessage ="Confirm password is requied.")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
