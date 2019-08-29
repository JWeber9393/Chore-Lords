using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoreLords.Models
{
    //Do we need to put our avatar subclasses in here?
    public class Character
    {
        [Key]
        public int Id { get; set; }
        public string Name{get;set;}
        protected int Health;
        protected int Wealth;
        protected int Power;
        protected int Intel;
        protected int Armor;
        protected int Xp;
        [Range(1, 20)]
        protected int Level;
        [Range(0, 1)]
        protected int IsChorelord{get;set;}


        // CONSTRUCTORS
        public Character(string name)
        {
            Name = name;
            Health = 50;
            Wealth = 0;
            Power = 10;
            Intel = 10;
            Armor = 10;
            Level = 1;
            Xp = 0;
        }

        //Instantiates a ChoreLord
        public Character(string name, int IsChorelord)
        {
            Name = name;
            Health = 100000;
            Wealth = 999999999;
            Power = 50000;
            Intel = 50000;
            Armor = 50000;
            Level = 20;
            Xp = 50;
        }
        // Nav Properties
        List<Chore> Chores {get; set;}



        // public Attack(Character target)
        // {

        // }
    }
    
}