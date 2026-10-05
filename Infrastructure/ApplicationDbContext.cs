using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Auto> Autos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>(c =>
            {
                c.HasKey(a => a.Id);
                c.Property(a => a.Marka).IsRequired();
                c.Property(a => a.Modell).IsRequired();
                c.Property(a => a.Evjarat).IsRequired();
                c.Property(a => a.Ar).IsRequired();
            });
        }
    }
}
