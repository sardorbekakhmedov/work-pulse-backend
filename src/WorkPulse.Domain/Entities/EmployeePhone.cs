using WorkPulse.Domain.Entities.Base;

namespace WorkPulse.Domain.Entities;

public class EmployeePhone : BaseEntity<long>
{
    public required string Phone { get; set; }

    public bool IsMain { get; set; }

    public int EmployeeId { get; set; }
    public virtual Employee? Employee { get; set; }
}