using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoreLords.Models
{
    public class Chore
    {
<<<<<<< HEAD

=======
        [Key]
        public int Id { get; set; }
        public int LaborerId{get;set;}
>>>>>>> 11cfa81a6c5acafc5e26fdb89a57fea1bf035202
        Character Laborer{get;set;}

        Character Creator{get; set;}


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

        public int CharacterId{get;set;}
    }
}