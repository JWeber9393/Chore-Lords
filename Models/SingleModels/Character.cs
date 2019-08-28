using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoreLords.Models
{
    abstract class Character
    {
        public string Name;
        protected int Health;
        protected int Wealth;
        protected int Power;
        protected int Armor;
        protected int Level;
        protected int Xp;
    

        public Character(string name)
        {
            Name = name;
            Health = 100;
            Wealth = 0;
            Power = 10;
            Armor = 10;
            Level = 1;
            Xp = 10;
        }
    }
}