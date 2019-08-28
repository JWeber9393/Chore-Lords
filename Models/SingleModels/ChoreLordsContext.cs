using Microsoft.EntityFrameworkCore;

namespace ChoreLords.Models
{
    public class ChoreLordsContext : DbContext
    {
        public ChoreLordsContext(DbContextOptions options) : base(options) { }

        public DbSet<User> users { get; set; }
<<<<<<< HEAD
        // public DbSet<Character> Character { get; set; }
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Viking>().HasBaseType<Character>();
        // }
=======
        public DbSet<Chore> chores { get; set; }
        public DbSet<Character> characters { get; set; }
>>>>>>> 343941f2af6a30b57272f072718f3db462e376b9

    }
}