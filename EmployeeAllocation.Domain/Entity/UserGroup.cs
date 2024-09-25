using EmployeeAllocation.Domain.Enums;

namespace EmployeeAllocation.Domain.Entity;

public class UserGroup : Base
{
    public string? Name { get; set; }
    public UserGroupEnum? Code { get; set; }
}
