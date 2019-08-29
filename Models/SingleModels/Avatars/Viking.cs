using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoreLords.Models
{
    class Viking : Character
    {
        public Viking(string name) : base(name)
        {
            Power = 75;
        }
        public virtual ICollection<Chore> Chores { get; set; }
    }
}