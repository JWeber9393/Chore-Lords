using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoreLords.Models
{
    public class Chore
    {
        [Key]
        public int Id { get; set; }
        public int LaborerId{get;set;}
        Character Laborer{get;set;}

        public string Title;
        public int Money;
        public int JobXp;
        public Chore(string title, int money, int jobXp)
        { 
            Title = title;
            Money = money;
            JobXp = jobXp;
        }
    }
}