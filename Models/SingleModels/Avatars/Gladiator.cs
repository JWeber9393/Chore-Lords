using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoreLords.Models
{
    class Gladiator : Character
    {
        public Gladiator(string name) : base(name)
        {
            Power = 50;
            Armor = 25;
        }

    }
}