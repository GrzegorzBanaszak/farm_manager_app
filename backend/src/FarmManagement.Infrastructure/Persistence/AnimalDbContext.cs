using FarmManagement.Domain.Animals.Aggregate;
using FarmManagement.Domain.Animals.Entities;
using FarmManagement.Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace FarmManagement.Infrastructure.Persistence
{
    public class AnimalDbContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; } = null!;
        public DbSet<HealthRecord> HealthRecords { get; set; } = null!;

        public AnimalDbContext(DbContextOptions<AnimalDbContext> opt) : base(opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnimalConfiguration());
            modelBuilder.ApplyConfiguration(new HealthRecordConfiguration());
        }
    }
}
