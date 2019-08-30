using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoreLords.Models
{
    public class Viking : Character
    {
        public Viking(string name) : base(name)
        {
            Power = 55;
            Armor = 30;
        }
        public virtual ICollection<Chore> Chores { get; set; }
    }
}