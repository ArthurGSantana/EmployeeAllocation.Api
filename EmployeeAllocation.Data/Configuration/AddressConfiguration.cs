using EmployeeAllocation.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeAllocation.Data.Configuration;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("Address");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Street)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(e => e.Number)
            .IsRequired()
            .HasMaxLength(10);
        builder.Property(e => e.City)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(e => e.State)
            .IsRequired()
            .HasMaxLength(2);
        builder.Property(e => e.Country)
            .IsRequired()
            .HasMaxLength(50);
        builder.Property(e => e.PostalCode)
            .IsRequired()
            .HasMaxLength(10);

        builder.HasQueryFilter(x => x.Active);
    }
}
