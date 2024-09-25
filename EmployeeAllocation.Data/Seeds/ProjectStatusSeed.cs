using System;
using EmployeeAllocation.Domain.Entity;
using EmployeeAllocation.Domain.Enums;
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
                Code = ProjectStatusEnum.New
            },
            new ProjectStatus
            {
                Id = new Guid("00000000-0000-0000-0000-000000000002"),
                Name = "In Progress",
                Code = ProjectStatusEnum.InProgress
            },
            new ProjectStatus
            {
                Id = new Guid("00000000-0000-0000-0000-000000000003"),
                Name = "Completed",
                Code = ProjectStatusEnum.Completed
            },
            new ProjectStatus
            {
                Id = new Guid("00000000-0000-0000-0000-000000000004"),
                Name = "Canceled",
                Code = ProjectStatusEnum.Canceled
            }
        );
    }
}
