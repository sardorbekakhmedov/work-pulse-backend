using WorkPulse.Domain.Entities.Base;
using WorkPulse.Domain.Enums;

namespace WorkPulse.Domain.Entities.Auth;

public class User : BaseEntity<long>
{
    public required string Login { get; set; }
    public required string PasswordHash { get; set; }

    public required string Phone { get; set; } // OTP shu yerga yuboriladi

    public UserRole Role { get; set; }
    public bool IsActive { get; set; }

    public int? EmployeeId { get; set; }
    public virtual Employee? Employee { get; set; }
}

