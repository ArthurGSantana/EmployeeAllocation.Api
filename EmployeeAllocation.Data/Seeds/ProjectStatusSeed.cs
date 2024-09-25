using System;
using EmployeeAllocation.Domain.Entity;
using EmployeeAllocation.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAllocation.Data.Seeds;

public class ProjectStatusSeed : ISeed
{
    public void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProjectStatus>().HasData(
            new ProjectStatus
            {
                Id = new Guid("00000000-0000-0000-0000-000000000001"),
                Name = "New",
                Code = 0
            },
            new ProjectStatus
            {
                Id = new Guid("00000000-0000-0000-0000-000000000002"),
                Name = "In Progress",
                Code = 1
            },
            new ProjectStatus
            {
                Id = new Guid("00000000-0000-0000-0000-000000000003"),
                Name = "Completed",
                Code = 2
            }
        );
    }
}
