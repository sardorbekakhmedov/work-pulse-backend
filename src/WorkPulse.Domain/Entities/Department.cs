using WorkPulse.Domain.Entities.Base;

namespace WorkPulse.Domain.Entities;

public class Department : BaseEntity<long>
{
    public required string Name { get; set; }
    public required string? Description { get; set; }

    public virtual ICollection<Employee>? Employees { get; set; }
}