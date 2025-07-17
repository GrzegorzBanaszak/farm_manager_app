using FarmManagement.Domain.Animals.Aggregate;
using FarmManagement.Domain.Animals.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmManagement.Infrastructure.Persistence.Configurations
{
    internal class AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.ToTable("Animals");

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id)
                .HasConversion(
                    id => id.Value,
                    value => new AnimalId(value))
                .ValueGeneratedNever();

            builder.Property(a => a.Tag)
                .HasConversion(
                    tag => tag.Value,
                    value => new TagNumber(value))
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(a => a.Species)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.DateOfBirth)
               .IsRequired();

            builder.HasMany(a => a.HealthRecords)
                   .WithOne()
                   .HasForeignKey("AnimalId");

        }
    }
}
