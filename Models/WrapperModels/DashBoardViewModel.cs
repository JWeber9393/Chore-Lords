using System.Collections.Generic;

namespace ChoreLords.Models
{
    public class DashBoardViewModel
    {
        Chore NewChore { get; set; }
        List<Chore> AllChores { get; set; }
    }
}