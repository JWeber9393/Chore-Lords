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
        public Character Laborer{get;set;}

        public Character Creator{get; set;}


        public string Title;
        public int Money;
        public int JobXp;
        public string Description;

        public Chore(string title, int money, int jobXp, string description)
        {  
            Title = title;
            Money = money;
            JobXp = jobXp;
            Description = description;
        }
    }
}
