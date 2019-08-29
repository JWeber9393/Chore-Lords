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

        // FIELDS
        public string Title{ get; set; }
        public int Money{get; set;}
        public int JobXp{get; set;}
        public string Description{get; set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // CONSTRUCTORS
        public Chore()
        {

        }
        public Chore(string title, int money, int jobXp, string description)
        {
            Title = title;
            Money = money;
            JobXp = jobXp;
            Description = description;
        }
    }
}
