using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoreLords.Models
{
    class ChoreLord : Character
    {
        public int ChoreId{get;set;}
        public List<Chore> ChoreList{get;set;}
        public ChoreLord(string name) :  base(name)
        {
            Name = name;
            Health = 10000;
        }
    }
}