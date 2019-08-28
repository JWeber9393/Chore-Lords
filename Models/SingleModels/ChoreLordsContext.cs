using Microsoft.EntityFrameworkCore;

namespace ChoreLords.Models
{
    public class ChoreLordsContext : DbContext
    {
        public ChoreLordsContext(DbContextOptions options) : base(options) { }

        public DbSet<User> users { get; set; }
        // public DbSet<Character> Character { get; set; }
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Viking>().HasBaseType<Character>();
        // }

    }
}