using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoreLords.Models
{
    public class LogRegWrapper
    {
        public User newUser{get;set;}
        public LogUser logUser{ get; set; }
    }
}