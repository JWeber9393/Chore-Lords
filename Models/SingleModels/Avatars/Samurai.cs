using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoreLords.Models
{
    public class Samurai : Character
    {
        
        public Samurai(string name) : base(name)
        {
            Power = 17;
            Intel = 50;
            Speed = 25;
        }
        // public virtual ICollection<Chore> Chores { get; set; }
    }
}