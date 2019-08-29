using System.Collections.Generic;

namespace ChoreLords.Models
{
    public class DashboardViewModel
    {
        public Chore Chore { get; set; }
        public List<Chore> Chores { get; set; }
    }
}