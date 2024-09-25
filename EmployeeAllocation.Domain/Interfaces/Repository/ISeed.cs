using Microsoft.EntityFrameworkCore;

namespace EmployeeAllocation.Domain.Interfaces.Repository;

public interface ISeed
{
    void Seed(ModelBuilder modelBuilder);
}
