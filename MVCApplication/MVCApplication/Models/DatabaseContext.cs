using Microsoft.EntityFrameworkCore;
using MVCApplication.Models.Entities;

namespace MVCApplication.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                  .HasIndex(u => u.EmailAddress)
                  .IsUnique();
                ;
        } 

        DbSet<User> Users { get; set; }
    }
}
