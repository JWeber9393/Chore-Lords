using Microsoft.EntityFrameworkCore;

namespace ChoreLords.Models
{
    public class ChoreLordsContext : DbContext
    {
        public ChoreLordsContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Chore> Chores { get; set; }
        public DbSet<Character> Characters { get; set; }

    }
}