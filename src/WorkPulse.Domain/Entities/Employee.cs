using WorkPulse.Domain.Entities.Base;
using WorkPulse.Domain.Enums;

namespace WorkPulse.Domain.Entities;

public class Employee : BaseEntity<long>
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? MiddleName { get; set; }
    public Gender Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime HireDate { get; set; }
    public WorkType WorkType { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }

    public string? PassportSeria { get; set; }
    public string? Pnfl { get; set; }

    public string? PhotoUrl { get; set; }

    public int? DepartmentId { get; set; }
    public virtual Department? Department { get; set; }

    public int? PositionId { get; set; }
    public Position? Position { get; set; }
    
    public virtual ICollection<EmployeePhone>? PhoneNumbers { get; set; }
}