using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoreLords.Models
{
    public class Gladiator : Character
    {
        
        public Gladiator(string name) : base(name)
        {
            Power = 40;
            Armor = 25;
            Speed = 15;
        }

        public virtual ICollection<Chore> Chores { get; set; }

    }
}