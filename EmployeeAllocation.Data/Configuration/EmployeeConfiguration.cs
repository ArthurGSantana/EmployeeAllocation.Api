using EmployeeAllocation.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeAllocation.Data.Configuration;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employee");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(e => e.Email)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(e => e.Phone)
            .IsRequired()
            .HasMaxLength(20);
        builder.Property(e => e.Document)
            .IsRequired()
            .HasMaxLength(20);
        builder.Property(e => e.JobFunction)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasIndex(u => u.Document).IsUnique();

        builder.HasQueryFilter(x => x.Active);
    }
}
