using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoreLords.Models
{
    class Avatar : Character
    {
        public int ChoreId{get;set;}
        List<Chore> Tasks{ get; set; }

        public Avatar(string name) : base(name)
        {
            List<Spell> Attacks;
        }
    }
}