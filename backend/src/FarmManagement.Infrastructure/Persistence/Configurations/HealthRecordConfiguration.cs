using System;
using FarmManagement.Domain.Animals.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmManagement.Infrastructure.Persistence.Configurations;

public class HealthRecordConfiguration : IEntityTypeConfiguration<HealthRecord>
{
    public void Configure(EntityTypeBuilder<HealthRecord> builder)
    {
        builder.ToTable("HealthRecords");

        builder.HasKey(hr => hr.Id);
        builder.Property(hr => hr.Id)
               .ValueGeneratedOnAdd();

        builder.Property(hr => hr.CheckDate)
               .IsRequired();

        builder.Property(hr => hr.Notes)
               .IsRequired()
               .HasMaxLength(1000);
    }
}