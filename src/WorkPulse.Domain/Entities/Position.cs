using WorkPulse.Domain.Entities.Base;

namespace WorkPulse.Domain.Entities;

public class Position : BaseEntity<long>
{ 
    public required string Name { get; set; }
    public string? Description { get; set; }
    
    public virtual ICollection<Employee>? Employees { get; set; }
}