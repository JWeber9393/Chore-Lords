using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoreLords.Models
{
    public class LogUser
    {
        [Required]
        [Display(Name = "Alias:")]
        public string log_alias { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string log_password { get; set; }
    }
}