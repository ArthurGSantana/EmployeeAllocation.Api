namespace EmployeeAllocation.Domain.Entity;

public class Allocation : Base
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int? Hours { get; set; }
    public Guid? EmployeeId { get; set; }
    public Employee? Employee { get; set; }
    public Guid? ProjectId { get; set; }
    public Project? Project { get; set; }
}
