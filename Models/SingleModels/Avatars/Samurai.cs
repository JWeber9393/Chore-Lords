using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoreLords.Models
{
    class Samurai : Character
    {
        public Samurai(string name) : base(name)
        {
            Power = 25;
            Intel = 50;
        }

        public virtual ICollection<Chore> Chores { get; set; }

    }
}