using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace BlazorCrud.Shared
{
    public class Usuario
    {
        [Required(ErrorMessage="Title is mandatory")]
        public string Title { get; set; }


        [Required(ErrorMessage="First name is mandatory",AllowEmptyStrings=false)]
        
        
        public string FirstName { get; set; }

        [Required(ErrorMessage="Last name is mandatory",AllowEmptyStrings=false)]
        
        
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of birth is mandatory")]
         public Nullable<DateTime> DateOfBirth { get; set; }

         [Required(ErrorMessage = "Insert your E-mail")]
         [RegularExpression(".+\\@.+\\..+",ErrorMessage = "Invalid E-mail...")]

        
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is mandatory")]
        [StringLength(30, ErrorMessage = "Must be between 6 and 30 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(30, ErrorMessage = "Must be between 6 and 30 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true", 
        ErrorMessage = "Accept Ts & Cs is required.")]
        public bool AcceptTerms { get; set; }
        
        
        
    }
}