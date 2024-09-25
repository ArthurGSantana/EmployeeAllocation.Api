using EmployeeAllocation.Domain.Entity;
using EmployeeAllocation.Domain.Enums;
using EmployeeAllocation.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAllocation.Data.Seeds;

public class UserGroupSeed : ISeed
{
    public void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserGroup>().HasData(
            new UserGroup
            {
                Id = new Guid("00000000-0000-0000-0000-000000000001"),
                Name = "Admin",
                Code = UserGroupEnum.Admin
            },
            new UserGroup
            {
                Id = new Guid("00000000-0000-0000-0000-000000000002"),
                Name = "Manager",
                Code = UserGroupEnum.Manager
            }
        );
    }
}
