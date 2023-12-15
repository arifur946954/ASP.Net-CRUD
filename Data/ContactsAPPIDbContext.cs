using ContractApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace ContractApi.Data
{
    public class ContactsAPPIDbContext : DbContext
    {
        public ContactsAPPIDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Contracts> contracts { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure one-to-many relationship
            modelBuilder.Entity<Contracts>()
                .HasMany(a => a.Books)
                .WithOne(b => b.contract)
                .HasForeignKey(b => b.ConId);
        }



    }
}
