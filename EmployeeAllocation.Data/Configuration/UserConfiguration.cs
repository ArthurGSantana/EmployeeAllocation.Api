using EmployeeAllocation.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeAllocation.Data.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("User");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(e => e.Email)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(e => e.Document)
            .IsRequired()
            .HasMaxLength(14);
        builder.Property(x => x.Password)
            .IsRequired()
            .HasMaxLength(512);

        builder.HasIndex(u => u.Email).IsUnique();
        builder.HasIndex(u => u.Document).IsUnique();

        builder.HasQueryFilter(x => x.Active);
    }
}
