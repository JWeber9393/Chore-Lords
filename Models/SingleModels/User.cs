using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoreLords.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Enter your first name!")]
        [MinLength(2, ErrorMessage = "First name must be 2 characters or longer!")]
        [RegularExpression("^[a-zA-Z ]*$")]
        [Display(Name = "First Name:")]
        public string fname {get;set;}
        
        [Required(ErrorMessage = "Enter your last name!")]
        [MinLength(2, ErrorMessage = "Last name must be 2 characters or longer!")]
        [RegularExpression("^[a-zA-Z ]*$")]
        [Display(Name = "Last Name:")]
        public string lname {get;set;}

        [Required(ErrorMessage = "Enter an alias!")]
        [Display(Name = "Alias:")]
        public string alias {get;set;}

        [Required(ErrorMessage = "Create a password!")]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string password {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [NotMapped]
        [Required(ErrorMessage = "Please confirm password!")]
        [Compare("password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password:")]
        public string conf_pw {get;set;}

        // Nav Properties
        public Character Character{get;set;}
        
    }
}

