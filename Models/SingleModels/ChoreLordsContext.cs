using Microsoft.EntityFrameworkCore;

namespace ChoreLords.Models
{
    public class ChoreLordsContext : DbContext
    {
        public ChoreLordsContext(DbContextOptions options) : base(options) { }

        public DbSet<User> users { get; set; }
        public DbSet<Chore> chores { get; set; }
        public DbSet<Character> characters { get; set; }

    }
}