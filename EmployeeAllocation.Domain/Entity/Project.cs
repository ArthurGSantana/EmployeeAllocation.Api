namespace EmployeeAllocation.Domain.Entity;

public class Project : Base
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public Guid? StatusId { get; set; }
    public ProjectStatus? Status { get; set; }
    public Guid? CompanyId { get; set; }
    public Company? Company { get; set; }
}
