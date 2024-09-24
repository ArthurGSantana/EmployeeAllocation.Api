namespace EmployeeAllocation.Domain.Entity;

public class Employee : Base
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Document { get; set; }
    public string? JobFunction { get; set; }
}
