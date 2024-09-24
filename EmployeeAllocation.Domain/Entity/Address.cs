namespace EmployeeAllocation.Domain.Entity;

public class Address : Base
{
    public string? Street { get; set; }
    public string? Number { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? PostalCode { get; set; }
}
