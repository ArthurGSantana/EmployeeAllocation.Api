namespace EmployeeAllocation.Domain.Entity;

public class User : Base
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? Document { get; set; }
}
