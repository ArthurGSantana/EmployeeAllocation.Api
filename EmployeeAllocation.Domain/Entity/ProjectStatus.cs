using EmployeeAllocation.Domain.Enums;

namespace EmployeeAllocation.Domain.Entity;

public class ProjectStatus : Base
{
    public string? Name { get; set; }
    public ProjectStatusEnum? Code { get; set; }
}
